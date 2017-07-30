/*
 * This file is part of SSQLib.
 *
 *   SSQLib is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   SSQLib is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with SSQLib.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace SSQLib
{
    /// <summary>
    /// Stores information about the Source server
    /// </summary>
    public class ServerInfo
    {
        /// <summary>
        /// Creates a new object with default values
        /// </summary>
        public ServerInfo() { }

        /// <summary>
        /// The name of the server
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The port the server uses
        /// </summary>
        public short Port { get; set; }

        /// <summary>
        /// The game being played on the server (i.e. Team Fortress (tf))
        /// </summary>
        public string Game { get; set; }

        /// <summary>
		/// Stores the app ID of the game used by the server
		/// </summary>
		public short AppID { get; set; }

        /// <summary>
        /// The game version running on the server
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The map currently being played on the server
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// The current player count on the server
        /// </summary>
        public byte PlayerCount { get; set; }

        /// <summary>
        /// The max amount of players allowed on the server
        /// </summary>
        public byte MaxPlayers { get; set; }

        /// <summary>
        /// The current bot count on the server
        /// </summary>
        public byte BotCount { get; set; }

        /// <summary>
        /// Stores whether the server is passworded or not
        /// </summary>
        public bool Password { get; set; }

        /// <summary>
        /// Stores whether the server is VAC protected or not
        /// </summary>
        public bool VAC { get; set; }

        /// <summary>
        /// Stores the type of server running (Listen, Dedicated, SourceTV)
        /// </summary>
        public DedicatedType Dedicated { get; set; }

        /// <summary>
        /// Stores the operating system of the server (Windows, Linux)
        /// </summary>
        public OSType OS { get; set; }

        /// <summary>
        /// Stores the Steam ID of the server
        /// </summary>
        public ulong SteamID { get; set; }

        /// <summary>
        /// Spectator port number for SourceTV.
        /// </summary>
        public short SourceTVPort { get; set; }
        /// <summary>
        /// Name of the spectator server for SourceTV.
        /// </summary>
        public string SourceTVServerName { get; set; }

        /// <summary>
        /// Tags that describe the game according to the server (for future use.)
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// The server's 64-bit GameID. If this is present, a more accurate AppID is present in the low 24 bits. The earlier AppID could have been truncated as it was forced into 16-bit storage.
        /// </summary>
        public ulong GameID { get; set; }

        /// <summary>
        /// Used to describe the type of server running
        /// </summary>
        public enum DedicatedType
        {
            /// <summary>
            /// Default value
            /// </summary>
            NONE,
            /// <summary>
            /// Listen server (locally hosted)
            /// </summary>
            LISTEN,
            /// <summary>
            /// Dedicated server
            /// </summary>
            DEDICATED,
            /// <summary>
            /// SourceTV server
            /// </summary>
            SOURCETV
        };

        /// <summary>
        /// Used to describe the operating system running on the server
        /// </summary>
        public enum OSType
        {
            /// <summary>
            /// Default value
            /// </summary>
            NONE,
            /// <summary>
            /// Windows server
            /// </summary>
            WINDOWS,
            /// <summary>
            /// Linux server
            /// </summary>
            LINUX
        };
    }
}
