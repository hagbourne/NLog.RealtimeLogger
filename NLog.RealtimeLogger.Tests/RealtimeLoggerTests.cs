﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄████████                                                                   ▄█
      █     ███    ███                                                                  ███
      █    ▄███▄▄▄▄██▀    ▄█████   ▄█████   █           ██     █     ▄▄██▄▄▄     ▄█████ ███        ██████     ▄████▄     ▄████▄     ▄█████    █████
      █   ▀▀███▀▀▀▀▀     ██   █    ██   ██ ██       ▀███████▄ ██   ▄█▀▀██▀▀█▄   ██   █  ███       ██    ██   ██    ▀    ██    ▀    ██   █    ██  ██
      █   ▀███████████  ▄██▄▄      ██   ██ ██           ██  ▀ ██▌  ██  ██  ██  ▄██▄▄    ███       ██    ██  ▄██        ▄██        ▄██▄▄     ▄██▄▄█▀
      █     ███    ███ ▀▀██▀▀    ▀████████ ██           ██    ██   ██  ██  ██ ▀▀██▀▀    ███       ██    ██ ▀▀██ ███▄  ▀▀██ ███▄  ▀▀██▀▀    ▀███████
      █     ███    ███   ██   █    ██   ██ ██▌    ▄     ██    ██   ██  ██  ██   ██   █  ███▌    ▄ ██    ██   ██    ██   ██    ██   ██   █    ██  ██
      █     ███    ███   ███████   ██   █▀ ████▄▄██    ▄██▀   █     █  ██  █    ███████ █████▄▄██  ██████    ██████▀    ██████▀    ███████   ██  ██
      █
      █       ███
      █   ▀█████████▄
      █      ▀███▀▀██    ▄█████   ▄█████     ██      ▄█████
      █       ███   ▀   ██   █    ██  ▀  ▀███████▄   ██  ▀
      █       ███      ▄██▄▄      ██         ██  ▀   ██
      █       ███     ▀▀██▀▀    ▀███████     ██    ▀███████
      █       ███       ██   █     ▄  ██     ██       ▄  ██
      █      ▄████▀     ███████  ▄████▀     ▄██▀    ▄████▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Unit tests for the RealtimeLogger class.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The MIT License (MIT)
      █
      █  Copyright (c) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  Permission is hereby granted, free of charge, to any person obtaining a copy
      █  of this software and associated documentation files (the "Software"), to deal
      █  in the Software without restriction, including without limitation the rights
      █  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
      █  copies of the Software, and to permit persons to whom the Software is
      █  furnished to do so, subject to the following conditions:
      █
      █  The above copyright notice and this permission notice shall be included in all
      █  copies or substantial portions of the Software.
      █
      █  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
      █  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
      █  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
      █  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
      █  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
      █  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
      █  SOFTWARE.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                              */

using System;
using NLog.Config;
using NLog.Targets;
using Xunit;

namespace NLog.RealtimeLogger.Tests
{
    /// <summary>
    ///     Tests for the <see cref="RealtimeLogger"/> class.
    /// </summary>
    public class RealtimeLoggerTests
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RealtimeLoggerTests"/> class.
        /// </summary>
        public RealtimeLoggerTests()
        {
            // configure the logger with a debugger target
            LoggingConfiguration config = new LoggingConfiguration();
            DebuggerTarget debug = new DebuggerTarget();
            config.AddTarget("debug", debug);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, debug));

            LogManager.Configuration = config;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///     Tests <see cref="RealtimeLogger.AppendLog(string, string, string, string, string)"/>.
        /// </summary>
        /// <param name="threadID">The ThreadID of the log.</param>
        /// <param name="dateTime">The DateTime of the log.</param>
        /// <param name="logLevel">The LogLevel of the log.</param>
        /// <param name="logger">The logger for the log.</param>
        /// <param name="message">The message for the log.</param>
        [Theory]
        [InlineData("1", "8/12/2016 9:10", "Trace", "Test", "Hello World!")]
        [InlineData("test", "test", "test", "test", "test")]
        public void AppendLog(string threadID, string dateTime, string logLevel, string logger, string message)
        {
            RealtimeLogger.AppendLog(threadID, dateTime, logLevel, logger, message);
        }

        /// <summary>
        ///     Tests <see cref="RealtimeLogger.AppendLog(string, string, string, string, string)"/> with enough logs to force
        ///     pruning of the log history.
        /// </summary>
        [Fact]
        public void AppendLogsToForcePrune()
        {
            SetVariable("RealtimeLogger.LogHistoryLimit", "5");

            Assert.Equal(5, RealtimeLogger.LogHistoryLimit);

            for (int i = 0; i < 10; i++)
            {
                RealtimeLogger.AppendLog("test", "test", "test", "test", "test");
            }

            Assert.Equal(4, RealtimeLogger.LogHistory.Count);
        }

        /// <summary>
        ///     Tests <see cref="RealtimeLogger.AppendLog(string, string, string, string, string)"/> with a subscriber attached.
        /// </summary>
        [Fact]
        public void AppendLogSubscription()
        {
            RealtimeLogger.LogAppended += EventHandler;
            RealtimeLogger.AppendLog("2", "8/12/2016 10:31", "Debug", "Test", "Hello World!");
        }

        /// <summary>
        ///     Tests the constructor of <see cref="RealtimeLoggerEventArgs"/>.
        /// </summary>
        [Fact]
        public void EventArgs()
        {
            DateTime dt = DateTime.Now;
            RealtimeLoggerEventArgs e = new RealtimeLoggerEventArgs("3", dt.ToString(), "Trace", "Test", "Hello World!");

            Assert.Equal(e.ThreadID, 3);
            Assert.Equal(e.DateTime.ToString(), dt.ToString());
            Assert.Equal(e.Level, LogLevel.Trace);
            Assert.Equal(e.Logger, "Test");
            Assert.Equal(e.Message, "Hello World!");
        }

        /// <summary>
        ///     Tests the constructor of <see cref="RealtimeLoggerEventArgs"/> with "bad" data.
        /// </summary>
        [Fact]
        public void EventArgsBad()
        {
            RealtimeLoggerEventArgs e = new RealtimeLoggerEventArgs("test", "test", "test", "test", "test");

            Assert.Equal(e.ThreadID, 1);
            Assert.IsType<DateTime>(e.DateTime);
            Assert.Equal(e.Level, LogLevel.Info);
            Assert.Equal(e.Logger, "test");
            Assert.NotEmpty(e.Message);
        }

        /// <summary>
        ///     Tests the <see cref="RealtimeLogger.LogHistoryLimit"/> property.
        /// </summary>
        [Fact]
        public void LogHistoryLimit()
        {
            SetVariable("RealtimeLogger.LogHistoryLimit", "500");
            Assert.Equal(500, RealtimeLogger.LogHistoryLimit);
        }

        /// <summary>
        ///     Tests the <see cref="RealtimeLogger.LogHistoryLimit"/> property with a known bad value.
        /// </summary>
        [Fact]
        public void LogHistoryLimitBad()
        {
            SetVariable("RealtimeLogger.LogHistoryLimit", "one");

            int val;

            Assert.Throws(typeof(FormatException), () => val = RealtimeLogger.LogHistoryLimit);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///     Dummy LogAppended event handler.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event parameters.</param>
        private void EventHandler(object sender, RealtimeLoggerEventArgs e)
        {
        }

        /// <summary>
        ///     Sets the specified variable in the NLog configuration to the specified value.
        /// </summary>
        /// <param name="variable">The variable to set.</param>
        /// <param name="value">The value to which to set the variable.</param>
        private void SetVariable(string variable, string value)
        {
            if (LogManager.Configuration != default(Config.LoggingConfiguration))
            {
                if (LogManager.Configuration.Variables.ContainsKey(variable))
                {
                    LogManager.Configuration.Variables[variable] = new Layouts.SimpleLayout(value);
                }
                else
                {
                    LogManager.Configuration.Variables.Add(variable, new Layouts.SimpleLayout(value));
                }
            }
        }

        #endregion Private Methods
    }
}