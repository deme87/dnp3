
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

#include <opendnp3/LogToStdio.h>

#include <opendnp3/LogEntry.h>
#include <iostream>

namespace opendnp3
{

LogToStdio LogToStdio::mInstance;

LogToStdio::LogToStdio() : mPrintLocation(false)
{}

void LogToStdio::SetPrintLocation(bool aPrintLocation)
{
	mPrintLocation = aPrintLocation;
}

void LogToStdio::Log(const LogEntry& arEntry)
{
#ifndef OPENDNP3_STRIP_LOG_MESSAGES
	std::unique_lock<std::mutex> lock(mMutex);
	std::cout << arEntry.LogString(mPrintLocation) << std::endl;
#endif
}

} //end ns
