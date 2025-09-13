using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class PartyExtensions
{
    public static IContainer Party(this IContainer container, PartyType? party)
    {
        if (party != null)
        {
            container.Column(col =>
            {
                if (party.PartyName?.Count > 0) 
                    col.Item().Text(party.PartyName[0].Name.Value).Bold();
                
                party.PartyIdentification?.ForEach(id => 
                    col.Item().Mono("Party ID", id.Id?.Value));
                
                if (party.PostalAddress != null) 
                    col.Item().Address(party.PostalAddress);
                
                if (party.Contact != null)
                {
                    col.Item().Field("Contact Name", party.Contact.Name?.Value);
                    col.Item().Mono("Telephone", party.Contact.Telephone?.Value);
                    col.Item().Mono("Email", party.Contact.ElectronicMail?.Value);
                }
            });
        }
        return container;
    }

    public static IContainer Address(this IContainer container, AddressType? address)
    {
        if (address != null)
        {
            container.Column(col =>
            {
                address.StreetName?.Value?.Let(v => col.Item().Text(v));
                address.AdditionalStreetName?.Value?.Let(v => col.Item().Text(v));
                address.BuildingNumber?.Value?.Let(v => col.Item().Text(v));
                address.CityName?.Value?.Let(v => col.Item().Text(v));
                address.PostalZone?.Value?.Let(v => col.Item().Text(v));
                address.Country?.IdentificationCode?.Value?.Let(v => col.Item().Text(v));
            });
        }
        return container;
    }
}
