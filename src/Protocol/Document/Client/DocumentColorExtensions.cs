using System.Threading.Tasks;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

// ReSharper disable CheckNamespace

namespace OmniSharp.Extensions.LanguageServer.Protocol.Client
{
    public static class DocumentColorExtensions
    {
        public static Task<Container<ColorInformation>> DocumentColor(this ILanguageClientDocument mediator, DocumentColorParams @params)
        {
            return mediator.SendRequest<DocumentColorParams, Container<ColorInformation>>(DocumentNames.DocumentColor, @params);
        }
    }
}
