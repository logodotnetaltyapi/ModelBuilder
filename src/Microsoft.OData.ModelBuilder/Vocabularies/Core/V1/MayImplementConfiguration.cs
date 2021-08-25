// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.
// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Core.V1
{
    /// <summary>
    /// A collection of qualified type names outside of the type hierarchy that instances of this type might be addressable as by using a type-cast segment.
    /// </summary>
    public partial class MayImplementConfiguration : VocabularyTermConfiguration
    {
        private readonly HashSet<string> _mayImplement = new HashSet<string>();

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.MayImplement";

        /// <summary>
        /// A collection of qualified type names outside of the type hierarchy that instances of this type might be addressable as by using a type-cast segment.
        /// </summary>
        /// <param name="mayImplement">The value(s) to set</param>
        /// <returns><see cref="MayImplementConfiguration"/></returns>
        public MayImplementConfiguration HasMayImplement(params string[] mayImplement)
        {
            _mayImplement.UnionWith(mayImplement);
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            if (!_mayImplement.Any())
            {
                return null;
            }

            var records = _mayImplement.Select(item => item.ToEdmExpression());
            return new EdmCollectionExpression(records);
        }
    }
}
