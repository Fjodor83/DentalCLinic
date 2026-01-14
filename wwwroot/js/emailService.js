// EmailJS Integration Service for Contact Form
window.emailService = {
    // Initialize EmailJS (call this once when the page loads)
    initialize: function(publicKey) {
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
    sendEmail: function(serviceId, templateId, formData) {
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
                .then(function(response) {
                    console.log('Email sent successfully', response.status, response.text);
                    resolve(response);
                }, function(error) {
                    console.error('Email send failed', error);
                    reject(error);
                });
        });
    }
};
