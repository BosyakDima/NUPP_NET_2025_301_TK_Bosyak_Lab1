using System;

namespace Zoo.Common
{
    // Інтерфейс, що гарантує наявність Id
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}