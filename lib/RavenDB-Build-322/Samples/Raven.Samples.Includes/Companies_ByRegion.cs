//-----------------------------------------------------------------------
// <copyright file="Companies_ByRegion.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using Raven.Client.Indexes;
using Raven.Database.Indexing;

namespace Raven.Samples.Includes
{
    public class Companies_ByRegion : AbstractIndexCreationTask
    {
        public override IndexDefinition CreateIndexDefinition()
        {
            return new IndexDefinition<Company>
            {

                Map = companies => from company in companies
                                   select new { company.Region }
                ,
            }.ToIndexDefinition(Conventions);
        }
    }
}
