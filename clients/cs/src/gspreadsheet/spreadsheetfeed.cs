/* Copyright (c) 2006 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections;
using System.Text;
using System.Xml;
using Google.GData.Client;
using Google.GData.Extensions;

namespace Google.GData.Spreadsheets
{
    /// <summary>
    /// Feed API customization class for defining a myspreadsheets feed.
    /// </summary>
    public class SpreadsheetFeed : AbstractFeed
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uriBase">The uri for this myspreadsheets feed.</param>
        /// <param name="iService">The Spreadsheets service.</param>
        public SpreadsheetFeed(Uri uriBase, IService iService)
        : base(uriBase, iService)
        {
        }

  
    
        /// <summary>
        /// returns a new entry for this feed
        /// </summary>
        /// <returns>AtomEntry</returns>
        public override AtomEntry CreateFeedEntry()
        {
            return new SpreadsheetEntry();
        }

        /// <summary>
        /// get's called after we already handled the custom entry, to handle all 
        /// other potential parsing tasks
        /// </summary>
        /// <param name="e"></param>
        protected override void HandleExtensionElements(ExtensionElementEventArgs e, AtomFeedParser parser)
        {
             Tracing.TraceMsg("\t HandleExtensionElements for Spreadsheet feed called");
        }

    }
}

