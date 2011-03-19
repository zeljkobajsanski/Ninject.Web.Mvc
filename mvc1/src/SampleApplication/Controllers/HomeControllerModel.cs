//-------------------------------------------------------------------------------
// <copyright file="HomeControllerModel.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Remo Gloor (remo.gloor@gmail.com)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace SampleApplication.Controllers
{
    /// <summary>
    /// The data model of the home controller
    /// </summary>
    public class HomeControllerModel : IHomeControllerModel
    {
        /// <summary>
        /// Gets the welcome message.
        /// </summary>
        /// <value>The welcome message.</value>
        public string WelcomeMessage
        {
            get
            {
                return "Welcome to MVC. From Home Controller Model.";
            }
        }
    }
}