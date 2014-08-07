using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ProjectSWGScriptEditor.FileReaders.STF
{
	static public class StfReader
	{
		static public StfEntry[] read(String stfPath)
		{
			FileStream stream = File.Open(stfPath,FileMode.Open);
			stream.Position = 9;

			int entryCount = readLittleEndianInt(stream);
			StfEntry[] entries = new StfEntry[entryCount];

			for (int i = 0; i < entryCount; i++)
			{
				int entryNumber = readLittleEndianInt(stream);
				stream.Position += 4;
				int characters = readLittleEndianInt(stream);

				byte[] characterBuffer = new byte[characters];
				for (int a = 0; a < characters; a++)
				{
					characterBuffer[a] = (byte) stream.ReadByte();
					stream.Position++;
				}
	
				string value = System.Text.Encoding.Default.GetString(characterBuffer);

				StfEntry entry = new StfEntry();
				entry.value = value;

				entries[i] = entry;
			}

			for (int i = 0; i < entryCount; i++)
			{
				int entryNumber = readLittleEndianInt(stream);
				int characters = readLittleEndianInt(stream);

				byte[] characterBuffer = new byte[characters];

				for (int a = 0; a < characters; a++)
				{
					characterBuffer[a] = (byte)stream.ReadByte();
				}

				string value = System.Text.Encoding.Default.GetString(characterBuffer);
				entries[i].key = value;
			}

			return entries;
		}

		static private int readLittleEndianInt(FileStream stream)
		{
			byte[] endianBuffer = new byte[4];
			stream.Read(endianBuffer, 0, 4);
			endianBuffer.Reverse();
			return BitConverter.ToInt32(endianBuffer, 0);
		}
	}
}
