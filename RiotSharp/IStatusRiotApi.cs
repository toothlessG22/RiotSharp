﻿using RiotSharp.StatusEndpoint;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiotSharp.Misc;

namespace RiotSharp
{
    /// <summary>
    /// Entry point for the status API.
    /// </summary>
    public interface IStatusRiotApi
    {
        /// <summary>
        /// Get the list of shards synchronously.
        /// </summary>
        /// <returns>A list of shards.</returns>
        List<Shard> GetShards();

        /// <summary>
        /// Get the list of shards asynchronously.
        /// </summary>
        /// <returns>A list of shards.</returns>
        Task<List<Shard>> GetShardsAsync();

        /// <summary>
        /// Get shard status synchronously.
        /// Returns the data available on the status.leagueoflegends.com website for the given region.
        /// </summary>
        /// <param name="region">Region for which to check the status.</param>
        /// <returns>A shard status object containing different information regarding the shard.</returns>
        ShardStatus GetShardStatus(Region region);

        /// <summary>
        /// Get shard status asynchronously.
        /// Returns the data available on the status.leagueoflegends.com website for the given region.
        /// </summary>
        /// <param name="region">Region for which to check the status.</param>
        /// <returns>A shard status object containing different information regarding the shard.</returns>
        Task<ShardStatus> GetShardStatusAsync(Region region);
    }
}
