// <copyright file="ItemStorage.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.Persistence.Json;
    
    /// <summary>
    /// A plain implementation of <see cref="ItemStorage"/>.
    /// </summary>
    public partial class ItemStorage : MUnique.OpenMU.DataModel.Entities.ItemStorage, IIdentifiable, IConvertibleTo<ItemStorage>
    {
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="Items" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public ICollection<Item> RawItems { get; } = new List<Item>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Entities.Item> Items
        {
            get => base.Items ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Entities.Item, Item>(this.RawItems);
            protected set
            {
                this.Items.Clear();
                foreach (var item in value)
                {
                    this.Items.Add(item);
                }
            }
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public ItemStorage Convert() => this;
    }
}