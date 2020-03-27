using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EventCallback
{
    
    public class StringSearcher
    {
        private string _pattern = string.Empty;

        public event EventHandler<StringSearcherArgs> Request;

        public StringSearcher(string pattern)
        {
            _pattern = pattern;
        }

        public void Search(List<string> list)
        {
            foreach (var entity in list)
            {
                if (Regex.IsMatch(entity, _pattern))
                {
                    var args = new StringSearcherArgs(entity);
                    Request?.Invoke(this, args);
                    if (args.CancelRequest)
                    {
                        break;
                    }
                }
            }
        }

    }

    public class StringSearcherArgs : EventArgs
    {
        public bool CancelRequest { get; set; }

        public string FoundEntity { get; }

        public StringSearcherArgs(string entityName)
        {
            FoundEntity = entityName;
        }
    }
}
