/*
 * Copyright (c) Contributors, http://opensimulator.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSim Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using libsecondlife;

namespace OpenSim.Framework
{
    /// <summary>
    /// Inventory Item - contains all the properties associated with an individual inventory piece.
    /// </summary>
    public class InventoryItemBase
    {
        /// <summary>
        /// A UUID containing the ID for the inventory item itself
        /// </summary>
        public LLUUID inventoryID;

        /// <summary>
        /// The UUID of the associated asset on the asset server
        /// </summary>
        public LLUUID assetID;

        /// <summary>
        /// This is an enumerated value determining the type of asset (eg Notecard, Sound, Object, etc)
        /// </summary>
        public int assetType;

        /// <summary>
        /// The type of inventory item. (Can be slightly different to the asset type
        /// </summary>
        public int invType;

        /// <summary>
        /// The folder this item is contained in 
        /// </summary>
        public LLUUID parentFolderID;

        /// <summary>
        /// The owner of this inventory item
        /// </summary>
        public LLUUID avatarID;

        /// <summary>
        /// The creator of this item
        /// </summary>
        public LLUUID creatorsID;

        /// <summary>
        /// The name of the inventory item (must be less than 64 characters)
        /// </summary>
        public string inventoryName;

        /// <summary>
        /// The description of the inventory item (must be less than 64 characters)
        /// </summary>
        public string inventoryDescription;

        /// <summary>
        /// A mask containing the permissions for the next owner (cannot be enforced)
        /// </summary>
        public uint inventoryNextPermissions;

        /// <summary>
        /// A mask containing permissions for the current owner (cannot be enforced)
        /// </summary>
        public uint inventoryCurrentPermissions;

        /// <summary>
        /// 
        /// </summary>
        public uint inventoryBasePermissions;

        /// <summary>
        /// 
        /// </summary>
        public uint inventoryEveryOnePermissions;
    }
}
