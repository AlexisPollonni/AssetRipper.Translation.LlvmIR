using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class bsearch
{
	public unsafe static void* Invoke(void* key, void* array, long array_size, long elem_size, void* compare)
	{
		void* result = null;
		long num = 0L;
		void* ptr = null;
		int num2 = 0;
		void* ptr2 = array;
		long num3 = array_size;
		unchecked
		{
			if (key == null || ptr2 == null || num3 == 0L || elem_size == 0L)
			{
				result = null;
			}
			else
			{
				while (true)
				{
					if ((ulong)num3 > 0uL)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num);
						num = (long)((ulong)num3 / 2uL);
						llvm_lifetime_start_p0.Invoke(8L, &ptr);
						ptr = (byte*)ptr2 + num * elem_size;
						llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = ((delegate*<void*, void*, int>)compare)(key, ptr);
						int num4;
						if (num2 == 0)
						{
							result = ptr;
							num4 = 1;
						}
						else
						{
							if (num2 < 0)
							{
								num3 = num;
							}
							else
							{
								num3 -= num + 1L;
								ptr2 = (byte*)ptr + elem_size;
							}
							num4 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num2);
						llvm_lifetime_end_p0.Invoke(8L, &ptr);
						llvm_lifetime_end_p0.Invoke(8L, &num);
						switch (num4)
						{
						case 0:
							continue;
						case 1:
							break;
						default:
							throw null;
						}
					}
					else
					{
						result = null;
					}
					break;
				}
			}
			return result;
		}
	}
}
