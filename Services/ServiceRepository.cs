using DentalCLinic.Models;
using System.Collections.Generic;
using System.Linq;

namespace DentalCLinic.Services
{
    public static class ServiceRepository
    {
        private static readonly List<ServiceData> _services = new()
        {
            new ServiceData
            {
                Slug = "bridges",
                Title = "Bridges",

                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <p>
                            Dental bridges take their name from the way they replace one or more missing teeth caused by trauma or decay.
                            A bridge is permanently attached to the neighboring teeth, providing stability and improving comfort while
                            eating and speaking.
                        </p>

                        <p>
                            If missing teeth are affecting your confidence or causing difficulties with speaking, chewing, or jaw
                            discomfort, our doctors can help you determine whether a bridge is the right solution for your needs.
                        </p>
                    </div>
                ",

                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <p>
                            The crowns that support a bridge can be made from metal, tooth‑colored materials, or a combination of both.
                            The choice depends on aesthetics, function, and tissue compatibility, ensuring the best outcome for each
                            individual case.
                        </p>

                        <p>
                            The example below shows a bridge replacing two missing teeth. Alternatives to a bridge include a fixed dental
                            implant or a removable partial denture.
                        </p>
                    </div>
                ",

                BeforeImage = "images/bridge-before.jpg",
                AfterImage = "images/bridge-after.jpg"
            },
            new ServiceData
            {
                Slug = "composite-restorations",
                Title = "Composite Restorations",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <p class='h5 text-sage mb-2'>Amalgam (Mercury) Free Fillings</p>

                        <p>
                             If you’re one of the many patients who prefer mercury-free, tooth-coloured fillings, you’ll be happy to know that our Doctors can accommodate your request.
                        </p>
                        <p>
                            Many people still have silver/metal mercury containing fillings from years past in their mouths. These fillings made up of a combination of metals and are sometimes referred to as mercury alloys. They are not particularly pleasing to the eye, and can also present a health issue for some.
                        </p>
                        <p>
                            By unavoidable ‘undercut’ design required to retain the filling material, the old mercury/metal fillings result in a weaker tooth. As they age the restoration expands putting pressure on the remaining tooth and causing micro fractures. As the old metal fillings lift, bacteria can leech under the filling resulting in further problems.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <p>
                            At the time, metal fillings were the best we had. Technology has allowed for the development of a number of new materials. Porcelain inlays, onlays, crowns and composite resins materials can create fillings that are tooth colored and aesthetically pleasing but they also are more conservative and add strength to the tooth.
                        </p>
                        <p>
                             We can improve your oral health and your smile by repairing or replacing your natural teeth with amalgam-free materials. Today amalgam-free options are available for all dental procedures. Teeth can be repaired with tooth colored fillings, inlays, onlays, veneers and/or crowns. Every situation is different, schedule an exam and find out what option best suits your needs.
                        </p>
                    </div>
                ",
                BeforeImage = "images/mercury-free-dentist-1.jpg", 
                AfterImage = "images/mercury-free-dentist-2.jpg"
            },
            new ServiceData
            {
                Slug = "cosmetic-veneers",
                Title = "Cosmetic Veneers",

                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <p>
                            Dental veneers are a cosmetic dentistry solution in which a thin layer of tooth‑colored porcelain or composite
                            is applied to the front surfaces of the teeth. They help correct worn enamel, uneven alignment or spacing,
                            discoloration, and minor chips or cracks.
                        </p>

                        <p>
                            While veneers are considered cosmetic because they create bright, well‑aligned and aesthetically pleasing
                            smiles, they also protect the surface of damaged teeth and may reduce the need for more extensive treatments.
                            Additional benefits include durability, improved appearance, and minimal removal of natural tooth structure
                            compared to crowns.
                        </p>

                        <p>
                                Veneers can address many common aesthetic concerns, including:<br />
                                <strong>Worn enamel:</strong> Over time, enamel can become worn, dulled, or discolored due to genetics,
                                diet (soft drinks, tea, coffee), smoking, medications, and other factors.
                                <strong>Wear and tear:</strong> As we age, teeth naturally develop chips, cracks, and uneven edges.
                        </p>
                    </div>
                ",

                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                                <strong>Genetics:</strong> Some individuals naturally have spacing between teeth that increases with age.<br />
                                <strong>Uneven teeth:</strong> Often caused by grinding or general wear over time.
                        <p>
                            <strong>Composite bonding</strong> also known as direct composite veneers is a cost‑effective, minimally
                            invasive method to restore small chips, cracks, and discoloration.
                        </p>

                        <h3 class='h5 text-sage mb-3'>When Are Veneers Appropriate?</h3>

                        <p>
                            Because removing natural tooth structure is permanent, our doctors always prioritize the most conservative
                            treatment options. If your natural teeth are already healthy and aesthetically acceptable, veneers may not
                            be the ideal choice.
                        </p>

                        <p>
                            For severely dull or discolored teeth, treatment options may include porcelain or composite veneers. Veneers
                            offer long‑lasting results and can significantly enhance the appearance of the smile and facial features by
                            improving tooth shape and alignment.
                        </p>
                    </div>
                ",

                BeforeImage = "images/bounding-before.jpg",
                AfterImage = "images/bounding-after.jpg"
            },
            new ServiceData
            {
                Slug = "crowns",
                Title = "Crowns",
                BeforeImageLabel = "",
                AfterImageLabel = "",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        
                        <p>
                            Sometimes referred to as “dental caps” Our doctors use crowns to improve the appearance, and overall strength of a previously restored or damaged tooth. It is a covering that is placed over a carefully prepped tooth or implant. 
                        </p>
                        <p>
                            A crown can strengthen the tooth when there is no longer sufficient tooth structure left to place a filling. Crowns may also be used to protect the structure of a tooth that is fractured or broken. A tooth that has had a root canal (endodontic treatment) will be brittle and crowns are often recommended to protect endo treated teeth.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                         <p>
                            There are many different types of crowns including those where the outer porcelain layer is fused to a metal sub-frame (Porcelain Fused to Metal Crowns or “PFM’s”) and those where there is no metal whatsoever (All Porcelain Crowns or Porcelain Jacket Crowns).
                        </p>
                        <p>
                            Crowns can also be made using various gold alloys, ( Full Gold Crown) which are very durable although sometimes less esthetic. The choice of material depends on the individual tooth, aesthetics and function.
                        </p>
                    </div>
                ",
                BeforeImage = "images/jacket-crowns.PNG", 
                AfterImage = "images/jacket-crowns-2.PNG"
            },
            new ServiceData
            {
                Slug = "endo-therapy",
                Title = "Root Canal Therapy",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Endodontic Treatment</h3>
                        <p>
                            Inside each tooth lies a slender strand of ‘pulp’, which contains nerves and blood vessels that provide nutrients to the tooth —that extends down to the tooth’s root. If the pulp becomes infected or injured, the tooth’s nerves die, and often without endodontic treatment, this causes the tooth die as well. 
                        </p>
                        <p>
                            When a tooth’s pulp becomes irreversibly inflamed and infected, endodontic treatment (a root canal), is required to prevent the infection from spreading into the tissue. If this happens there will sometimes be facial or gum swelling which can also become very painful if left untreated.
                        </p>
                        <p>
                            Having a root canal preserves the tooth by removing the infection within the roots and filling the space with a special material. The only other option unfortunately would be to have the tooth extracted.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <p>
                            The procedure is relatively simple, despite what most people believe or have heard. The tooth is numbed (with anesthetic), a small opening is made through the biting surface of the tooth to access the infected material and relieve the pressure caused by the infection. The infected material is then removed and the pulp chamber is sealed. 
                        </p>
                        <p>
                            Most of the time, a root canal is a relatively simple one or two visit procedure with little or no discomfort. The length of procedure varies depending on the number of roots and canals the particular tooth has.The treated tooth is then non-vital, which means it is more fragile/brittle than a healthy tooth and a crown/cap is generally recommended to prevent it from fracturing.
                        </p>
                        <p>
                            Please contact our office for more information on root canal therapy if you have any questions.
                        </p>
                    </div>
                ",
                BeforeImage = "images/Root_Canal.WEBP", 
                AfterImage = null
            },
            new ServiceData
            {
                Slug = "extractions",
                Title = "Extractions",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <p>
                            No one likes the idea of losing a tooth. Our doctors recommend an extraction only when no other treatment
                            option is available to save the tooth.
                        </p>

                        <p>
                            Wisdom tooth extractions are a common part of growing up and are often needed in the late teenage years or
                            early twenties. Even if they do not cause immediate discomfort, impacted wisdom teeth can place pressure on
                            adjacent teeth and may lead to inflammation or irritation as they continue to erupt.
                        </p>
                    </div>
                ",


                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <p>
                            When wisdom teeth do not have enough space to emerge properly, they may become impacted. Impacted wisdom teeth
                            can push against neighboring teeth, contribute to crowding, or lead to infections and gum inflammation.
                        </p>

                        <p>
                            For these reasons, early evaluation is important. Our doctors will assess the position and development of your
                            wisdom teeth and determine whether extraction is the safest and most effective option to protect your long‑term
                            oral health.
                        </p>
                    </div>
                ",

                BeforeImage = "images/Extraction.WEBP", 
                AfterImage = null
            },
            new ServiceData
            {
                Slug = "hygiene",
                Title = "Hygiene",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Oral Hygiene</h3>
                        <p>
                            The oral hygiene you practice at home—brushing at least two times a day and flossing every day—is great for keeping your smile healthy and beautiful between visits to your dentist, but it doesn’t take the place of the more in-depth cleaning we’re able to perform during your regular hygiene visits. Here we can also perform fluoride and desensitizing treatments, take actions to prevent or reverse gum disease, or even tell you about a variety of dental options to keep your breath feeling and smelling fresh!
                        </p>
                        <p>
                            Periodontal disease, also known as gum disease, is the most common disease known to mankind. 75% of all adults have had it or will have it at some time. Gum disease can cause bleeding gums, sensitive teeth, bad breath and in advanced cases, lead to loose teeth, tooth loss and adversely affect your ability to eat, speak and smile properly. Periodontal disease has also been shown to increase the risk of heart disease, respiratory disease, increase the severity of diabetes, and increase incidence of premature births.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Our Hygiene Program</h3>
                        <p>
                            Our Hygiene program is committed to preventing and eliminating this destructive disease. Periodontal disease is caused by a large build-up of the bacteria found in plaque, which erode the soft and underlying hard tissues of the mouth.
                        </p>
                        <p>
                            The early stages (gingivitis) are marked by red, inflamed, bleeding gums. If it is detected in these early stages, gum disease can often be reversed.
                        </p>
                        <p>
                            For more advanced cases of gum disease multiple appointments may be required and a shorter interval between professional hygiene appointments may be recommended to maintain health.
                        </p>
                    </div>
                ",
                BeforeImage = "images/Clean&Polish_before.PNG", 
                AfterImage = "images/Clean&Polish_after.PNG"
            },
            new ServiceData
            {
                Slug = "implant-restoration",
                Title = "Implant Restoration",
                BeforeImageLabel = "",
                AfterImageLabel = "",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <p>
                            Our doctors have been placing dental implants for over a decade. A dental implant restoration is attaching artificial teeth to titanium root implants anchored in the bone below the gum line. After the anchor has been surgically placed in the jawbone, excess bone and gum grow around the implant, holding it firmly in place. An artificial tooth or teeth can then be attached to the implant. The end result is a strong, secure tooth that is virtually indistinguishable from natural teeth. They can be used to secure individual teeth, bridges or full dentures.
                        </p>
                        <p>
                            Dental implants are designed to provide a foundation for replacement teeth that look, feel, and function like natural teeth. The person who has lost teeth regains the ability to eat virtually anything and can smile with confidence, knowing that teeth are permanently fixed, and appear natural.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <p>
                            The implants themselves are tiny titanium posts that are placed into the jawbone where teeth are missing. The bone bonds with the titanium, creating a strong foundation for artificial teeth/crowns. Implants can help preserve facial structure, preventing the bone deterioration which occurs when teeth are missing. This has the visual impact of a face lift, making you look years younger.
                        </p>
                        <p>
                            Dental implants are changing the way people live! With them, people are rediscovering the comfort and confidence to eat, speak, laugh and enjoy life. If you feel implant dentistry is the choice for you, call or email our office today for a complimentary consultation.
                        </p>
                         <h3 class='h5 text-sage mb-3'>Frequently Asked Questions about Dental Implants</h3>
                         <p>The following link will help to answer your many questions regarding dental Implants.</p>
                         
                            <a href='http://www.knowyourteeth.com/infobites/abc/article/?abc=I&iid=307&aid=1257' target='_blank' class='text-sage text-decoration-underline'>KnowYourTeeth - Dental Implants Info</a>
                         
                    </div>
                ",
                BeforeImage = "images/dental-implant_1.jpg", 
                AfterImage = "images/dental-implant_2.WEBP"
            },
            new ServiceData
            {
                Slug = "laser-therapy",
                Title = "Laser Therapy",
                BeforeImageLabel = "",
                AfterImageLabel = "",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Laser Assisted Gum Therapy</h3>
                        <p>
                            New technology means more solutions—laser assisted gum therapy.
                        </p>
                        <p>
                            We are pleased to announce that we have added a leading edge laser system to our practice. The Odyssey Diode laser is a safe and patient friendly device that can be used to perform minor gum surgeries and preventive procedures that in the past required surgeries.
                        </p>
                         <p>
                           The leading edge technology of the Diode Laser is just one more way that we’re making your visits more comfortable while increasing the level of care we provide.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Benefits</h3>
                        <p>
                            The oral health benefits of the diode laser are possible because the laser light is specifically absorbed by cellular pigments, melanin and hemoglobin. This results in the destruction of bacterial cells that commonly live in deep pockets of gum tissue. 
                        </p>
                        <p>
                            The laser can also be focused on a tiny precise point with the delicate fiber optic cable to do exact work and these results in minimal swelling. The laser also coagulates at the same time so there is no more bleeding that is commonly associated with scalpel surgery.
                        </p>
                    </div>
                ",
                BeforeImage = "images/dawn_light_diode_laser_1.jpg", 
                AfterImage = "images/dawn_light_diode_laser_2.WEBP"
            },
            new ServiceData
            {
                Slug = "mini-implants",
                Title = "Mini Dental Implants",
                BeforeImageLabel = "",
                AfterImageLabel = "",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Small Diameter Implants</h3>
                        <p>
                            Are you interested in implant dentistry but a traditional implant is not feasible?
                        </p>
                        <p>
                            For most people suffering with the inconvenience of removable dentures or the embarrassment of missing teeth, traditional dental implant surgery is a viable option with high success rates. However, there are some cases where mini dental implants are a better choice for both economic and health purposes.
                        </p>
                         <p>
                           Mini dental implants, also known as small diameter dental implants, are teeth implants with a diameter less than three millimeters. They are most often used to secure removable lower jaw dentures but may also be used for single crowns and replacement teeth. Mini implants are a useful alternative to traditional tooth implants when the candidate for surgery is seeking a lower cost option or lacks sufficient bone and/or gum tissue to secure a larger diameter implant.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Cost & Benefits</h3>
                        <p>
                            Typically, mini implants cost less than half the price of traditional larger implants and can be priced as low as a quarter of the cost. In addition, the decreased operation and recovery time associated with mini implants makes them a less expensive alternative to conventional implants.
                        </p>
                        <p>
                            Mini dental implants are also often chosen for elderly patients who lack the necessary bone and gum tissue to secure a larger implant and would thus require bone grafting surgery. Because mini implants do not generally require a bone graft, unnecessary risks and complications associated with major surgery for elderly patients, in particular, can be avoided when this option is selected.
                        </p>
                    </div>
                ",
                BeforeImage = "images/MIni_implant_1.jpg", 
                AfterImage = "images/MIni_implant_2.jpg"
            },
            new ServiceData
            {
                Slug = "sealants",
                Title = "Sealants",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Pits and Fissures</h3>
                        <p>
                            The top surfaces of your teeth – where the chewing takes place – aren’t smooth and flat. They are crevices with tiny hills and valleys – called pits and fissures. These are places where plaque can build up safe from your toothbrush and dental floss. Some of the pits and fissures are so narrow that even a single bristle from your toothbrush can’t get deep enough to clean them out.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Prevention</h3>
                        <p>
                            One method of preventing cavities from developing in the pits and fissures is to seal them with a varnish called a pit and fissure sealant. If our doctors determine you need a sealant to help protect your teeth from decay, some special steps are taken.
                        </p>
                        <p>
                            Our Certified Dental Assistants will clean the tooth first, apply a solution to ‘etch’ the surface and make it easier for the pit and fissure sealant to stick. Keeping the area dry is very important, if the tooth gets wet, the sealant might not stick properly. Once everything is ready, we then apply the sealant right over the pits and fissures on the tooth surface. A special light is then used to cure the sealant and the whole procedure is quick and painless.
                        </p>
                    </div>
                ",
                BeforeImage = "images/sealants.jpg", 
                AfterImage = null
            },
            new ServiceData
            {
                Slug = "tmj-pain",
                Title = "TMJ - Jaw and Headache Pain",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>What is TMJ?</h3>
                        <p>
                            The temporomandibular joint (TMJ) connects your jawbone to your skull. TMJ disorders can cause pain in your jaw joint and in the muscles that control jaw movement. This condition is sometimes called TMD (temporomandibular disorder).
                        </p>
                        <p>
                            TMJ disorders can be caused by various factors including jaw injury, arthritis, genetics, or habits such as teeth grinding (bruxism). Many people who have jaw pain also tend to clench or grind their teeth, although many people habitually clench or grind their teeth and never develop TMJ disorders.
                        </p>
                        <h3 class='h5 text-sage mb-3'>Common Symptoms</h3>
                        <ul>
                            <li>Pain or tenderness of your jaw</li>
                            <li>Pain in one or both temporomandibular joints</li>
                            <li>Aching pain in and around your ear</li>
                            <li>Difficulty chewing or pain while chewing</li>
                            <li>Aching facial pain</li>
                            <li>Locking of the joint, making it difficult to open or close your mouth</li>
                        </ul>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Treatment Options</h3>
                        <p>
                            In some cases, the symptoms of TMJ disorders may go away without treatment. If your symptoms persist, our doctors may recommend a variety of treatment options, often more than one to be done at the same time.
                        </p>
                        <p>
                            <strong>Medications:</strong> Along with other nonsurgical treatments, medications that may help relieve the pain associated with TMJ disorders include pain relievers, anti-inflammatories, muscle relaxants, and in some cases, low doses of tricyclic antidepressants.
                        </p>
                        <p>
                            <strong>Therapies:</strong> Non-drug therapies for TMJ disorders include oral splints or mouth guards (occlusal appliances), physical therapy, and counseling to help you understand the factors and behaviors that may aggravate your pain.
                        </p>
                        <p>
                            If you're experiencing jaw pain, headaches, or difficulty with jaw movement, please contact our office to schedule a consultation. Our team can help diagnose the cause of your discomfort and recommend appropriate treatment options.
                        </p>
                    </div>
                ",
                BeforeImage = "images/tmj-diagram.jpg",
                AfterImage = null
            },
            new ServiceData
            {
                Slug = "whitening",
                Title = "Teeth Whitening",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Professional Teeth Whitening</h3>
                        <p>
                            A brighter, whiter smile can make a significant difference in your appearance and confidence. At Oceanside Dental Centre, we offer professional teeth whitening solutions that are safe, effective, and produce dramatic results.
                        </p>
                        <p>
                            Over time, teeth can become stained or discolored due to various factors including food and beverages (coffee, tea, red wine), tobacco use, aging, medications, and certain medical conditions. Professional whitening can help reverse these effects and restore your smile's natural brightness.
                        </p>
                        <h3 class='h5 text-sage mb-3'>ZOOM Laser Whitening</h3>
                        <p>
                            Our in-office ZOOM laser whitening treatment provides immediate, dramatic results in just one visit. The procedure takes approximately one hour and can whiten your teeth by several shades. A special light-activated gel is applied to your teeth, and the ZOOM light helps accelerate the whitening process.
                        </p>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Take-Home Bleaching Kits</h3>
                        <p>
                            For patients who prefer to whiten their teeth at home, we offer professional-grade take-home bleaching kits. These kits include custom-fitted trays made from impressions of your teeth and professional-strength whitening gel.
                        </p>
                        <p>
                            The custom trays ensure even application of the whitening gel and prevent irritation to your gums. Most patients see noticeable results within one to two weeks of consistent use.
                        </p>
                        <h3 class='h5 text-sage mb-3'>Which Option is Right for You?</h3>
                        <p>
                            <strong>ZOOM In-Office:</strong> Ideal for patients who want immediate results or have a special event coming up.
                        </p>
                        <p>
                            <strong>Take-Home Kits:</strong> Perfect for patients who prefer the convenience of whitening at home on their own schedule.
                        </p>
                        <p>
                            Our dental team can help you determine which whitening option is best suited for your needs and lifestyle. Contact us today to schedule a consultation.
                        </p>
                    </div>
                ",
                BeforeImage = "images/whitening-before.jpg",
                AfterImage = "images/whitening-after.jpg",
                BeforeImageLabel = "BEFORE",
                AfterImageLabel = "AFTER"
            },
            new ServiceData
            {
                Slug = "children-seniors",
                Title = "Children & Seniors Dentistry",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Dentistry for All Stages of Life</h3>
                        <p>
                            At Oceanside Dental Centre, we believe that quality dental care should be accessible to patients of all ages. We are proud to offer specialized services for both our youngest and our most experienced patients.
                        </p>
                        <h3 class='h5 text-sage mb-3'>Children's Dentistry</h3>
                        <p>
                            We understand that a child's first dental experiences can shape their attitude toward oral health for life. Our team takes special care to make dental visits fun, educational, and stress-free for children.
                        </p>
                        <ul>
                            <li>We are a <strong>'Healthy Kids'</strong> office</li>
                            <li>Dental sealants for cavity prevention</li>
                            <li>Gentle check-ups and cleanings</li>
                            <li>Preventative approach to a smile for life</li>
                            <li>Education on proper brushing and flossing techniques</li>
                        </ul>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Senior's Dentistry</h3>
                        <p>
                            As we age, our dental needs change. We offer comprehensive dental services tailored to the unique needs of our senior patients, helping them maintain healthy smiles and optimal oral function.
                        </p>
                        <ul>
                            <li>Full & Partial Dentures</li>
                            <li>Mini-implants for lower teeth</li>
                            <li>Cleanings & restorative services</li>
                            <li>Dry mouth treatment</li>
                            <li>Gum disease management</li>
                        </ul>
                        <div class='alert alert-success mt-4'>
                            <h5 class='alert-heading'><strong>10% Senior Special Discount</strong></h5>
                            <p class='mb-0'>We offer a 10% discount on all services for our senior patients!</p>
                        </div>
                    </div>
                ",
                BeforeImage = "images/children-dentistry.jpg",
                AfterImage = "images/senior-dentistry.jpg",
                BeforeImageLabel = "Children",
                AfterImageLabel = "Seniors"
            },
            new ServiceData
            {
                Slug = "child-first-visit",
                Title = "Child's First Visit",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Making the First Visit Special</h3>
                        <p>
                            The first dental visit is an important milestone in your child's healthcare journey. At Oceanside Dental Centre, we strive to make this experience positive, fun, and educational.
                        </p>
                        <h3 class='h5 text-sage mb-3'>When Should My Child First Visit the Dentist?</h3>
                        <p>
                            The Canadian Dental Association recommends that children have their first dental visit within six months of the eruption of their first tooth, or by age one. Early visits help establish good oral health habits and allow us to monitor your child's dental development.
                        </p>
                        <h3 class='h5 text-sage mb-3'>What to Expect</h3>
                        <p>
                            During your child's first visit, our friendly team will:
                        </p>
                        <ul>
                            <li>Gently examine your child's teeth and gums</li>
                            <li>Check for any early signs of decay or developmental issues</li>
                            <li>Clean the teeth if appropriate</li>
                            <li>Discuss proper oral hygiene techniques</li>
                            <li>Answer any questions you may have</li>
                        </ul>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Preparing Your Child</h3>
                        <p>
                            Here are some tips to help prepare your child for their first dental visit:
                        </p>
                        <ul>
                            <li><strong>Stay positive:</strong> Talk about the visit in a positive, matter-of-fact way</li>
                            <li><strong>Read books:</strong> There are many children's books about visiting the dentist</li>
                            <li><strong>Play pretend:</strong> Practice 'opening wide' and counting teeth at home</li>
                            <li><strong>Avoid negative words:</strong> Don't use words like 'hurt,' 'shot,' or 'drill'</li>
                            <li><strong>Schedule wisely:</strong> Choose a time when your child is usually well-rested</li>
                        </ul>
                        <h3 class='h5 text-sage mb-3'>Building Healthy Habits</h3>
                        <p>
                            Early dental visits help children understand that taking care of their teeth is a normal, important part of staying healthy. We focus on prevention and education to set your child up for a lifetime of healthy smiles.
                        </p>
                        <p>
                            Contact us today to schedule your child's first dental appointment!
                        </p>
                    </div>
                ",
                BeforeImage = "images/child-first-visit.jpg",
                AfterImage = null
            },
            new ServiceData
            {
                Slug = "healthy-kids",
                Title = "Healthy Kids Program",
                DescriptionCol1 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>BC Healthy Kids Program</h3>
                        <p>
                            Oceanside Dental Centre is proud to be a participating provider in the BC Healthy Kids Program. This program provides basic dental coverage for eligible children and youth in British Columbia.
                        </p>
                        <h3 class='h5 text-sage mb-3'>Who is Eligible?</h3>
                        <p>
                            The Healthy Kids Program is available to children and youth (18 years and under) in families receiving:
                        </p>
                        <ul>
                            <li>Medical Services Plan (MSP) Premium Assistance</li>
                            <li>Income Assistance</li>
                            <li>Disability Assistance</li>
                        </ul>
                        <h3 class='h5 text-sage mb-3'>Covered Services</h3>
                        <p>
                            The program covers basic dental services including:
                        </p>
                        <ul>
                            <li>Check-ups and examinations</li>
                            <li>Cleanings</li>
                            <li>X-rays</li>
                            <li>Fillings</li>
                            <li>Extractions</li>
                        </ul>
                    </div>
                ",
                DescriptionCol2 = @"
                    <div style='text-align:justify'>
                        <h3 class='h5 text-sage mb-3'>Our Commitment</h3>
                        <p>
                            We accept Healthy Kids Dental Insurance <strong>at par</strong> for all children 18 years old and under. This means families pay no additional fees for covered services.
                        </p>
                        <p>
                            We believe every child deserves access to quality dental care, regardless of their family's financial situation. Our team is committed to providing the same high standard of care to all our patients.
                        </p>
                        <h3 class='h5 text-sage mb-3'>How to Enroll</h3>
                        <p>
                            If you think your child may be eligible for the Healthy Kids Program, you can:
                        </p>
                        <ul>
                            <li>Contact Health Insurance BC at 1-800-663-7100</li>
                            <li>Visit <a href='https://www2.gov.bc.ca/gov/content/health/health-drug-coverage/msp/bc-residents/benefits/services-covered-by-msp/supplementary-benefits' target='_blank' class='text-sage'>gov.bc.ca</a> for more information</li>
                            <li>Ask our front desk staff for assistance</li>
                        </ul>
                        <p>
                            Contact us today to schedule an appointment for your child!
                        </p>
                    </div>
                ",
                BeforeImage = "images/healthy-kids.jpg",
                AfterImage = null
            }

        };

        public static ServiceData? GetService(string slug)
        {
            return _services.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.CurrentCultureIgnoreCase));
        }

        public static ServiceData GetPlaceholder(string slug, string title)
        {
             return new ServiceData
             {
                 Slug = slug,
                 Title = title,
                 Description = $@"
                    <p>We are currently updating the content for <strong>{title}</strong>.</p>
                    <p>Please check back shortly or contact our office for more information about this service.</p>"
             };
        }
    }
}
