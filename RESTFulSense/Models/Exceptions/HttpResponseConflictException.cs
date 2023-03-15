// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Collections;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc;

namespace RESTFulSense.Models.Exceptions
{
    public class HttpResponseConflictException : HttpResponseException
    {
        public HttpResponseConflictException()
            : base(httpResponseMessage: default, message: default) { }

        public HttpResponseConflictException(HttpResponseMessage responseMessage, string message)
            : base(responseMessage, message) { }

        public HttpResponseConflictException(
            HttpResponseMessage responseMessage,
            ValidationProblemDetails problemDetails) : base(responseMessage, problemDetails.Title)
        {
            AddData((IDictionary)problemDetails.Errors);
        }
    }
}
