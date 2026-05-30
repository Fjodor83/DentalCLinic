// EmailJS Integration Service for Contact Form
window.emailService = {
    // Initialize EmailJS (call this once when the page loads)
    initialize: function (publicKey) {
        if (typeof emailjs !== 'undefined') {
            emailjs.init(publicKey);
            console.log('EmailJS initialized successfully');
            return true;
        } else {
            console.error('EmailJS library not loaded');
            return false;
        }
    },

    // Send contact form email
    sendEmail: function (serviceId, templateId, formData) {
        return new Promise((resolve, reject) => {
            if (typeof emailjs === 'undefined') {
                reject('EmailJS not initialized');
                return;
            }

            // Template parameters for EmailJS
            const templateParams = {
                from_name: formData.name,
                from_email: formData.email,
                phone: formData.phone,
                message: formData.message,
                to_email: 'info@oceansidedentalcentre.com', // Your clinic email
                reply_to: formData.email
            };

            emailjs.send(serviceId, templateId, templateParams)
                .then(function (response) {
                    console.log('Email sent successfully', response.status, response.text);
                    resolve(response);
                }, function (error) {
                    console.error('Email send failed', error);
                    reject(error);
                });
        });
    },

    // Send contact form with dual emails (admin notification + patient auto-reply)
    sendContactForm: function (formData, serviceId, adminTemplateId, patientTemplateId) {
        return new Promise(async (resolve, reject) => {
            if (typeof emailjs === 'undefined') {
                resolve({
                    success: false,
                    message: 'EmailJS not initialized'
                });
                return;
            }

            try {
                // Template parameters for admin email
                const adminParams = {
                    from_name: formData.name,
                    from_email: formData.email,
                    phone: formData.phone || 'Not provided',
                    subject: formData.subject,
                    message: formData.message,
                    to_email: 'info@oceansidedentalcentre.com',
                    reply_to: formData.email
                };

                // Template parameters for patient auto-reply
                const patientParams = {
                    from_name: formData.name,      // Nome del paziente
                    email: formData.email,         // Email destinatario (corrisponde a {{email}})
                    subject: formData.subject      // Subject del messaggio
                };

                // Send both emails in parallel
                const results = await Promise.allSettled([
                    emailjs.send(serviceId, adminTemplateId, adminParams),
                    emailjs.send(serviceId, patientTemplateId, patientParams)
                ]);

                // Check if both succeeded
                const adminSuccess = results[0].status === 'fulfilled';
                const patientSuccess = results[1].status === 'fulfilled';

                if (adminSuccess && patientSuccess) {
                    console.log('Both emails sent successfully');
                    resolve({
                        success: true,
                        message: 'Both emails sent successfully'
                    });
                } else if (adminSuccess && !patientSuccess) {
                    console.warn('Admin email sent but auto-reply failed');
                    resolve({
                        success: true,
                        message: 'Message sent but confirmation email failed'
                    });
                } else {
                    console.error('Email sending failed');
                    resolve({
                        success: false,
                        message: 'Error sending emails'
                    });
                }
            } catch (error) {
                console.error('Unexpected error', error);
                resolve({
                    success: false,
                    message: 'Unexpected error occurred'
                });
            }
        });
    }
};
