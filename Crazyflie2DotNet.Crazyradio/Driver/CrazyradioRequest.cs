﻿namespace Crazyflie2DotNet.Crazyradio.Driver
{
	/// <summary>
	///     The vendor request identifiers for Crazyradio USB dongle.
	///     See http://wiki.bitcraze.se/projects:Crazyradio:protocol#dongle_configuration_and_functions_summary
	///     for more information regarding Crazyradio's vendor requests.
	/// </summary>
	internal enum CrazyradioRequest
	{
		/// <summary>
		///     Request to set the Crazyradio USB dongle channel.
		/// </summary>
		SetChannel = 0x01,

		/// <summary>
		///     Request to set the Crazyradio USB dongle address.
		/// </summary>
		SetAddress = 0x02,

		/// <summary>
		///     Request to set the Crazyradio USB dongle data rate.
		/// </summary>
		SetDataRate = 0x03,

		/// <summary>
		///     Request to set the Crazyradio USB dongle power level.
		/// </summary>
		SetPowerLevel = 0x04,

		/// <summary>
		///     Request to set the Crazyradio USB dongle to automatically wait for acknowledge packets (ACK).
		/// </summary>
		SetAutoActEnabled = 0x10,

		/// <summary>
		///     Request to set the Crazyradio USB dongle aknowledge packet (ACK) retry delay.
		/// </summary>
		SetAckRetryDelay = 0x05,

		/// <summary>
		///     Request to set the Crazyradio USB dongle aknowledge packet (ACK) retry count.
		/// </summary>
		SetAckRetryCount = 0x06,

		/// <summary>
		///     Request to get/set the Crazyradio USB dongle to acknowledge packets (ACK).
		/// </summary>
		AcknowledgePackets = 0x10,

		/// <summary>
		///     Request to set the Crazyradio USB dongle continuous carrier mode.
		/// </summary>
		SetContinuousCarrierMode = 0x20,

		/// <summary>
		///     Request to tell the Crazyradio USB dongle to begin scanning channels or to get the results of the request. You must
		///     tell Crazyradio USB dongle to scan channel before you try to get results.
		/// </summary>
		ScanChannels = 0x21,

		/// <summary>
		///     Request to launch Crazyradio USB dongle's bootloader.
		/// </summary>
		LaunchBootloader = 0xFF
	}
}