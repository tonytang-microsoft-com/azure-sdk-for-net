// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Automation;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    public static partial class RunbookOperationsExtensions
    {
        /// <summary>
        /// Retrieve the content of runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static RunbookContentResponse Content(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ContentAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the content of runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static Task<RunbookContentResponse> ContentAsync(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return operations.ContentAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static RunbookCreateResponse Create(this IRunbookOperations operations, string automationAccount, RunbookCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).CreateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static Task<RunbookCreateResponse> CreateAsync(this IRunbookOperations operations, string automationAccount, RunbookCreateParameters parameters)
        {
            return operations.CreateAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static RunbookCreateResponse CreateWithDraft(this IRunbookOperations operations, string automationAccount, RunbookCreateDraftParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).CreateWithDraftAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static Task<RunbookCreateResponse> CreateWithDraftAsync(this IRunbookOperations operations, string automationAccount, RunbookCreateDraftParameters parameters)
        {
            return operations.CreateWithDraftAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the runbook by name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).DeleteAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the runbook by name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return operations.DeleteAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static RunbookGetResponse Get(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).GetAsync(automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static Task<RunbookGetResponse> GetAsync(this IRunbookOperations operations, string automationAccount, string runbookName)
        {
            return operations.GetAsync(automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static RunbookListResponse List(this IRunbookOperations operations, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ListAsync(automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static Task<RunbookListResponse> ListAsync(this IRunbookOperations operations, string automationAccount)
        {
            return operations.ListAsync(automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static RunbookListResponse ListNext(this IRunbookOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static Task<RunbookListResponse> ListNextAsync(this IRunbookOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static RunbookGetResponse Update(this IRunbookOperations operations, string automationAccount, RunbookUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).UpdateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static Task<RunbookGetResponse> UpdateAsync(this IRunbookOperations operations, string automationAccount, RunbookUpdateParameters parameters)
        {
            return operations.UpdateAsync(automationAccount, parameters, CancellationToken.None);
        }
    }
}
