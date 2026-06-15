# Guida: spostare oceansidedentalcentre.com su Cloudflare (sito nuovo + email intatta)

> Obiettivo: far puntare il dominio **oceansidedentalcentre.com** al nuovo sito su **Cloudflare Pages**,
> **senza perdere l'email** (cPanel @ Hosting Nation, server `159.203.56.94`).
>
> Principio di sicurezza: **i record del sito si proxano (nuvola ARANCIONE), i record email NO (nuvola GRIGIA / "DNS only").**

---

## ⚠️ Il fix che evita di perdere l'email
Oggi l'`MX` punta al dominio stesso (`oceansidedentalcentre.com`). Se il dominio nudo lo gestisce
Cloudflare Pages, quel nome risolve agli IP di Cloudflare e **la posta si perde**.
**Per questo l'MX va spostato su `mail.oceansidedentalcentre.com`** (che resta puntato al server di posta vero).

---

## Passo 0 — Backup di sicurezza
Nel pannello Hosting Nation (cPanel → **Zone Editor**) fai uno screenshot di TUTTI i record DNS attuali.
È la tua rete di sicurezza. (Sotto trovi comunque tutti i valori già ricostruiti.)

## Passo 1 — Aggiungi il dominio a Cloudflare
1. Dashboard Cloudflare → **Add a site** → `oceansidedentalcentre.com` → piano **Free**.
2. Cloudflare scansiona e importa i record. **Confronta** con la tabella sotto e correggi/aggiungi ciò che manca.

## Passo 2 — DNS: valori esatti da incollare

### 📧 EMAIL — proxy = **DNS only (nuvola GRIGIA)**, TTL = Auto

| Tipo | Nome | Valore / Destinazione | Priorità |
|------|------|------------------------|----------|
| MX   | `@`  | `mail.oceansidedentalcentre.com` | `0` |
| A    | `mail` | `159.203.56.94` | — |
| A    | `webmail` | `159.203.56.94` | — |
| A    | `cpanel` | `159.203.56.94` | — |
| A    | `autodiscover` | `159.203.56.94` | — |

**SPF** — Tipo `TXT`, Nome `@`, valore (una riga sola):
```
v=spf1 +a +mx +ip4:159.203.56.94 include:relay.mailchannels.net +ip4:165.227.35.147 +ip4:104.145.239.53 +ip4:104.145.239.103 +include:sendgrid.net ~all
```
> (L'originale aveva `include:sendgrid.net` ripetuto due volte: è inutile, ne basta uno. Per il resto è identico.)

**DKIM** — Tipo `TXT`, Nome `default._domainkey`, valore (una riga sola):
```
v=DKIM1; k=rsa; p=MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtGaUjKLFJyVo7ue01FpNKoTNW9BpS4g91mGVp3rFtdtvuiwazSBx1YT98G3qarXVdglynjgmUXSQ+w+KF72o7zxbuWINXvZPmWPOIJqAJ3i6473ym75/ieRGFfezPLIbh/wLP9YxWo3VWBwb5DkhyUT/qFYSciT1j4DYhAAzPnHSGsDE8xOiA2jKbVJxtxfyisMZXOHjcOlXQ7pCPbGNrLhPz7B2nRtvCHdi/PKRHvhBtsiZn8xLtetx7Jq/qQuv2tBj4/DFWoOkR3nLV+DdUKboosGLT4+9YHl9eQW3ubYXuNJwf21SPHH2/MMv04h7XDhvJXzSLDx8lK/TchvquQIDAQAB;
```

**DMARC (consigliato, oggi assente)** — Tipo `TXT`, Nome `_dmarc`, valore:
```
v=DMARC1; p=none; rua=mailto:info@oceansidedentalcentre.com
```
> Opzionale ma utile: migliora la consegna e ti manda i report. `p=none` = solo monitoraggio, non blocca nulla.

> ❗ Se Cloudflare durante l'import ha trovato altri record (es. `ftp`, altri sottodomini) che puntano a
> `159.203.56.94`, **lasciali e mettili su DNS only (grigio)**.

### 🌐 SITO — proxy = **Proxied (nuvola ARANCIONE)**

| Tipo | Nome | Valore |
|------|------|--------|
| CNAME | `@` | `<tuo-progetto>.pages.dev` |
| CNAME | `www` | `<tuo-progetto>.pages.dev` |

> Questi due li crea **in automatico Cloudflare** quando, al Passo 4, aggiungi i domini nel progetto Pages.
> Sostituisci `<tuo-progetto>` col nome reale del progetto Pages (es. `oceanside`).

## Passo 3 — Cambia i nameserver (presso il registrar)
Cloudflare ti assegna 2 nameserver tipo:
```
xxxx.ns.cloudflare.com
yyyy.ns.cloudflare.com
```
Vai dal **registrar** del dominio (probabilmente Hosting Nation) e **sostituisci**
`ns1.hosting-nation.net` / `ns2.hosting-nation.net` con i due di Cloudflare.
Propagazione: da pochi minuti a qualche ora. L'email continua a funzionare durante l'attesa
(i record di posta sono già corretti su entrambi i lati).

## Passo 4 — Collega il dominio al sito Pages
Quando in Cloudflare il dominio è **"Active"**:
1. Progetto **Pages → Custom domains → Set up a domain**
2. Aggiungi `www.oceansidedentalcentre.com`  → poi anche  `oceansidedentalcentre.com`
3. SSL/HTTPS: automatico (pochi minuti).
4. Dominio principale = **www** (combacia con `sitemap.xml` e i dati Schema del sito).
   Imposta una **Redirect Rule**: da `oceansidedentalcentre.com/*` → `https://www.oceansidedentalcentre.com/$1` (301).

## Passo 5 — Verifiche finali (DA FARE SUBITO DOPO)
- [ ] 🌐 `https://www.oceansidedentalcentre.com` apre il **nuovo** sito (HTTPS, lucchetto ok)
- [ ] 🌐 `https://oceansidedentalcentre.com` reindirizza a `www`
- [ ] 🔁 Hard refresh su `https://www.oceansidedentalcentre.com/clinic` → NON dà 404
- [ ] 📧 Ricevi una mail di test su `info@oceansidedentalcentre.com`
- [ ] 📤 Invii una mail DA `info@oceansidedentalcentre.com` (controlla che non finisca in spam)
- [ ] 🌐 `https://webmail.oceansidedentalcentre.com` accessibile
- [ ] 🔎 In Google Search Console reinvii `sitemap.xml`

---

## 🛑 Da NON fare
- **Non disdire l'hosting/email su Hosting Nation.** L'email resta fisicamente su `159.203.56.94`:
  se chiudi quell'account, perdi la posta. Si sposta solo il DNS e il sito web.
- Non proxare (arancione) i record di posta `mail/webmail/cpanel/autodiscover/MX`: la posta non passa per Cloudflare.

## Rollback (se qualcosa va storto)
Rimetti i nameserver originali al registrar:
```
ns1.hosting-nation.net
ns2.hosting-nation.net
```
Tutto torna com'era in pochi minuti.

---

### Promemoria deploy del sito
La cartella da caricare su Pages è `publish-cloudflare\wwwroot` (rigenerala con
`dotnet publish -c Release -o .\publish-cloudflare`). Deve contenere il file `_redirects`
(`/* /index.html 200`) per il routing SPA.
