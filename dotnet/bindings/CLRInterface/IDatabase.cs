﻿
//
// Licensed to Green Energy Corp (www.greenenergycorp.com) under one or
// more contributor license agreements. See the NOTICE file distributed
// with this work for additional information regarding copyright ownership.
// Green Energy Corp licenses this file to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file except in
// compliance with the License.  You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// This file was forked on 01/01/2013 by Automatak, LLC and modifications
// have been made to this file. Automatak, LLC licenses these modifications to
// you under the terms of the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automatak.DNP3.Interface
{        
    /// <summary>
    /// Interface called to load data into an outstation or receive data from a master
    /// start() / end() must be called before / after any calls to update.
    /// </summary>
    public interface IDatabase
	{
        /// <summary>
        /// Start a transaction
        /// </summary>
		void Start();

        /// <summary>
        /// Update a Binary input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>        
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
		bool Update(Binary update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a Binary input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>        
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(DoubleBitBinary update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update an Analog input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(Analog update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a Counter
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(Counter update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a FrozenCounter
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(FrozenCounter update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a BinaryOutputStatus
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(BinaryOutputStatus update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update an AnalogOutputStatus
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(AnalogOutputStatus update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a TimeAndInterval
        /// </summary>
        /// <param name="update"></param>
        /// <param name="index"></param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Update(TimeAndInterval update, System.UInt16 index);

        /// <summary>
        /// Update a Binary input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>        
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<Binary,Binary> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a Binary input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>        
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<DoubleBitBinary,DoubleBitBinary> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update an Analog input
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<Analog,Analog> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a Counter
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<Counter,Counter> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a FrozenCounter
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<FrozenCounter,FrozenCounter> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a BinaryOutputStatus
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<BinaryOutputStatus,BinaryOutputStatus> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update an AnalogOutputStatus
        /// </summary>
        /// <param name="update">measurement to update</param>
        /// <param name="index">index of measurement</param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<AnalogOutputStatus, AnalogOutputStatus> update, System.UInt16 index, bool forceEvent = false);

        /// <summary>
        /// Update a TimeAndInterval
        /// </summary>
        /// <param name="update"></param>
        /// <param name="index"></param>
        /// <param name="forceEvent"> if true, an event is created regardess of the last reported value</param>
        /// <returns> true if the point exists </returns>
        bool Modify(Func<TimeAndInterval,TimeAndInterval> update, System.UInt16 index);

        /// <summary>
        /// End a transaction
        /// </summary>
		void End();
	}
}
