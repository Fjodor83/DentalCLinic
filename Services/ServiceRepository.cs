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
                Description = @"
                    <p class='lead'>Named for the way that they “bridge” or replace missing teeth lost by trauma or tooth decay. A bridge is permanently attached to the adjacent teeth, which makes it much more functional when eating and talking.</p>
                    <p>If missing teeth are making you feel self-conscious, or you’re noticing problems with speaking, chewing, or any jaw pain please ask our Doctors if a bridge may be right for you.</p>
                    <p>Crowns that anchor bridges are made of either metal or tooth colored materials, and sometimes a combination of the two. Aesthetics, function, and tissue compatibility are considered when selecting the best material for each individual case, pre treatment.</p>
                    <p>The image below shows a bridge replacing two missing teeth. Alternatives to a bridge would be a fixed dental implant or a removable partial denture.</p>",
                BeforeImage = "images/bridge-before.jpg", 
                AfterImage = "images/bridge-after.jpg"
            }
        };

        public static ServiceData? GetService(string slug)
        {
            return _services.FirstOrDefault(s => s.Slug.ToLower() == slug.ToLower());
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
