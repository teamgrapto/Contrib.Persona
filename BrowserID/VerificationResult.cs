﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contrib.Persona.BrowserID
{
    public class VerificationResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether assertion provideded by the browser is verified with the the relying party.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this it is verified; otherwise, <c>false</c>.
        /// </value>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
    }
}