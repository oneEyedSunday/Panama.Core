﻿namespace Panama.Entities
{
    public class KeyValuePair : IModel
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }
}