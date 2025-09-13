using Frank.Finance.Documents.Ubl.CreditNote;
using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.Reminder;

namespace Frank.Finance.Documents.Ubl.Renderer.Models;

public record RenderContext(ITranslator Translator, Language Language, InvoiceType? Invoice = null, CreditNoteType? CreditNote = null, ReminderType? Reminder = null);
