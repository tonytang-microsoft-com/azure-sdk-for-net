// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for VirtualMachineOperations.
    /// </summary>
    public static partial class VirtualMachineOperationsExtensions
    {
            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<LabVirtualMachine> List(this IVirtualMachineOperations operations, string resourceGroupName, string labName, ODataQuery<LabVirtualMachine> odataQuery = default(ODataQuery<LabVirtualMachine>))
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).ListAsync(resourceGroupName, labName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LabVirtualMachine>> ListAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, ODataQuery<LabVirtualMachine> odataQuery = default(ODataQuery<LabVirtualMachine>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static LabVirtualMachine GetResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).GetResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachine> GetResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Virtual Machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            public static LabVirtualMachine CreateOrUpdateResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).CreateOrUpdateResourceAsync(resourceGroupName, labName, name, labVirtualMachine), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Virtual Machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachine> CreateOrUpdateResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Virtual Machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            public static LabVirtualMachine BeginCreateOrUpdateResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).BeginCreateOrUpdateResourceAsync(resourceGroupName, labName, name, labVirtualMachine), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Virtual Machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachine> BeginCreateOrUpdateResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void DeleteResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).DeleteResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void BeginDeleteResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).BeginDeleteResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Modify properties of virtual machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            public static LabVirtualMachine PatchResource(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).PatchResourceAsync(resourceGroupName, labName, name, labVirtualMachine), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify properties of virtual machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachine> PatchResourceAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachine labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchResourceWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Apply artifacts to Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='applyArtifactsRequest'>
            /// </param>
            public static void ApplyArtifacts(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, ApplyArtifactsRequest applyArtifactsRequest)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).ApplyArtifactsAsync(resourceGroupName, labName, name, applyArtifactsRequest), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Apply artifacts to Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='applyArtifactsRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApplyArtifactsAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, ApplyArtifactsRequest applyArtifactsRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApplyArtifactsWithHttpMessagesAsync(resourceGroupName, labName, name, applyArtifactsRequest, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Apply artifacts to Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='applyArtifactsRequest'>
            /// </param>
            public static void BeginApplyArtifacts(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, ApplyArtifactsRequest applyArtifactsRequest)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).BeginApplyArtifactsAsync(resourceGroupName, labName, name, applyArtifactsRequest), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Apply artifacts to Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='applyArtifactsRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginApplyArtifactsAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, ApplyArtifactsRequest applyArtifactsRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginApplyArtifactsWithHttpMessagesAsync(resourceGroupName, labName, name, applyArtifactsRequest, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Start a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void Start(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).StartAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Start a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void BeginStart(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).BeginStartAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Stop a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void Stop(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).StopAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stop a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StopWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Stop a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            public static void BeginStop(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).BeginStopAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stop a Lab VM. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual Machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IVirtualMachineOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LabVirtualMachine> ListNext(this IVirtualMachineOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LabVirtualMachine>> ListNextAsync(this IVirtualMachineOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
