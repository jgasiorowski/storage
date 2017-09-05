﻿namespace Storage.Net.Blob
{
   /// <summary>
   /// Options for listing storage content
   /// </summary>
   public class ListOptions
   {
      private string _prefix;

      public string FolderPath { get; set; }

      /// <summary>
      /// Prefix to filter the name by
      /// </summary>
      public string Prefix
      {
         get => _prefix;
         set
         {
            GenericValidation.CheckBlobPrefix(value);
            _prefix = Prefix;
         }
      }

      /// <summary>
      /// When true, operation will recursively navigate down the folders
      /// </summary>
      public bool Recurse { get; set; }
   }
}