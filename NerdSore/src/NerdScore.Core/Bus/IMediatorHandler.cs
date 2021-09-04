using NerdScore.Core.Messages;
using System.Threading.Tasks;

namespace NerdScore.Core.Bus
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
