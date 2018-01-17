using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes2018
{
    public class Joke
    {
        internal Joke() { }

        internal int _jokeId;
        internal string _title;
        internal string _teaser;
        internal string _jokeText;
        internal int _categoryId;
        internal bool _isFeatured;

        public int JokeId
        {
            get
            {
                return _jokeId;
            }
            set
            {
                if (_jokeId == value)
                {
                    return;
                }
                _jokeId = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title cannot be null or empty");
                }
                _title = value;
            }
        }

        public string Teaser
        {
            get
            {
                return _teaser;
            }
            set
            {
                if (_teaser == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teaser cannot be null or empty");
                }
                _teaser = value;
            }
        }

        public string JokeText
        {
            get
            {
                return _jokeText;
            }
            set
            {
                if (_jokeText == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("JokeText cannot be null or empty");
                }
                _jokeText = value;
            }
        }


        public int CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                if (_categoryId == value)
                {
                    return;
                }
                _categoryId = value;
            }
        }

        public bool IsFeatured
        {
            get
            {
                return _isFeatured;
            }
            set
            {
                if (_isFeatured == value)
                {
                    return;
                }
                _isFeatured = value;
            }
        }
    }
}
