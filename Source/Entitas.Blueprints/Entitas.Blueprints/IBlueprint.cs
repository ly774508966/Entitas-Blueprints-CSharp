﻿namespace Entitas.Blueprints
{
    using System.Collections.Generic;

    public interface IBlueprint
    {
        /// <summary>
        ///   Types of the components to add to the entity.
        /// </summary>
        IList<string> ComponentTypes { get; }

        /// <summary>
        ///   Unique identifier of this blueprint.
        ///   Used in dictionaries to improve lookup performance.
        /// </summary>
        string Id { get; }

        /// <summary>
        ///   Values to initialize the component properties with.
        /// </summary>
        IDictionary<string, object> PropertyValues { get; }
    }
}