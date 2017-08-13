using System;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types

namespace ColasCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			// Retrieve storage account from connection string.
			CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
				CloudConfigurationManager.GetSetting("StorageConnectionString"));

			// Create the queue client.
			CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

			// Retrieve a reference to a container.
			CloudQueue queue = queueClient.GetQueueReference("myqueue");

			// Create the queue if it doesn't already exist
			queue.CreateIfNotExists();
        }
    }
}
