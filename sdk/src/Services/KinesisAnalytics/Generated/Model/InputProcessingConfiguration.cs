/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides a description of a processor that is used to preprocess the records in the
    /// stream prior to being processed by your application code. Currently, the only input
    /// processor available is <a href="https://aws.amazon.com/documentation/lambda/">AWS
    /// Lambda</a>.
    /// </summary>
    public partial class InputProcessingConfiguration
    {
        private InputLambdaProcessor _inputLambdaProcessor;

        /// <summary>
        /// Gets and sets the property InputLambdaProcessor. 
        /// <para>
        /// The <a>InputLambdaProcessor</a> that is used to preprocess the records in the stream
        /// prior to being processed by your application code.
        /// </para>
        /// </summary>
        public InputLambdaProcessor InputLambdaProcessor
        {
            get { return this._inputLambdaProcessor; }
            set { this._inputLambdaProcessor = value; }
        }

        // Check to see if InputLambdaProcessor property is set
        internal bool IsSetInputLambdaProcessor()
        {
            return this._inputLambdaProcessor != null;
        }

    }
}