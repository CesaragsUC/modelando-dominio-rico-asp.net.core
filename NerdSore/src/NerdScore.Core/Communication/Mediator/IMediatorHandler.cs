﻿using NerdScore.Core.Messages;
using NerdScore.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace NerdScore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;

        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
    }
}
