﻿using CQRSlite.Commands;

namespace CQRS
{
    /// <summary>
    /// Generic Command Handler
    /// </summary>
    /// <typeparam name="T"><see cref="ICommand"/> to handle</typeparam>
    public interface ICommandHandler<in T> : IHandler<T> where T : ICommand
    {
    }
}
