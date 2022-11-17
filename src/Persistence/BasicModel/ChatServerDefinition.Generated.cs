// <copyright file="ChatServerDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel;

using MUnique.OpenMU.Persistence.Json;

/// <summary>
/// A plain implementation of <see cref="ChatServerDefinition"/>.
/// </summary>
public partial class ChatServerDefinition : MUnique.OpenMU.DataModel.Configuration.ChatServerDefinition, IIdentifiable, IConvertibleTo<ChatServerDefinition>
{
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="Endpoints" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("endpoints")]
    public ICollection<ChatServerEndpoint> RawEndpoints { get; } = new List<ChatServerEndpoint>();
    
    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint> Endpoints
    {
        get => base.Endpoints ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint, ChatServerEndpoint>(this.RawEndpoints);
        protected set
        {
            this.Endpoints.Clear();
            foreach (var item in value)
            {
                this.Endpoints.Add(item);
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
    public ChatServerDefinition Convert() => this;
}
