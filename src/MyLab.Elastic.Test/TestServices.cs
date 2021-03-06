﻿namespace MyLab.Elastic.Test
{
    public class TestServices<TDoc>
        where TDoc : class
    {
        public string IndexName { get; set; }
        public IEsManager Manager { get; set; }
        public IIndexSpecificEsSearcher<TDoc> Searcher { get; set; }
        public IIndexSpecificEsIndexer<TDoc> Indexer { get; set; }
    }
}