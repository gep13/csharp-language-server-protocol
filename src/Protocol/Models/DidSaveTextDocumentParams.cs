using OmniSharp.Extensions.Embedded.MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OmniSharp.Extensions.LanguageServer.Protocol.Serialization;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Models
{
    public class DidSaveTextDocumentParams : ITextDocumentIdentifierParams, IRequest
    {
        /// <summary>
        ///  The document that was saved.
        /// </summary>
        public TextDocumentIdentifier TextDocument { get; set; }

        /// <summary>
        ///  Optional the content when saved. Depends on the includeText value
        ///  when the save notifcation was requested.
        /// </summary>
        [Optional]
        public string Text { get; set; }
    }
}
