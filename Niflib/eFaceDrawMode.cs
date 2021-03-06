/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */

namespace Niflib
{
	using System;

    /// <summary>
    /// Enum eFaceDrawMode
    /// </summary>
    public enum eFaceDrawMode : uint
	{
        /// <summary>
        /// The dra w_ cc w_ o r_ both
        /// </summary>
        DRAW_CCW_OR_BOTH,
        /// <summary>
        /// The dra w_ CCW
        /// </summary>
        DRAW_CCW,
        /// <summary>
        /// The dra w_ cw
        /// </summary>
        DRAW_CW,
        /// <summary>
        /// The dra w_ both
        /// </summary>
        DRAW_BOTH
    }
}
