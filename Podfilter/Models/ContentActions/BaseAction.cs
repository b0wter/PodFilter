﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podfilter.Models.ContentActions
{
    public abstract class BaseAction<T> : IContentAction<T>
    {
        /// <summary>
        /// Returns wether content of the given type can be used with this action.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public abstract bool CanParse(Type t);

        /// <summary>
        /// Performs an action on the given content.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public abstract T ModifyContent(T content);

        /// <summary>
        /// Calls <see cref="ParseContent(string)"/> followed by <see cref="ModifyContent(T)"/>.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public T ParseAndModifyContent(string content)
        {
            var parsedContent = ParseContent(content);
            var modifiedContent = ModifyContent(parsedContent);
            return modifiedContent;
        }

        /// <summary>
        /// Converts a string into an instance of T.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        protected abstract T ParseContent(string content);
    }
}
