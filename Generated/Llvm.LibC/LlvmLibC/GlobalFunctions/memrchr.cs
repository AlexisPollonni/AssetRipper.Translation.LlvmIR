using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memrchr
{
	public unsafe static void* Invoke(void* src, int c, long n)
	{
		void* result = null;
		void* ptr = null;
		sbyte b = 0;
		void* ptr2 = null;
		long num = n;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = src;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)c;
			while (true)
			{
				if (num != 0L)
				{
					llvm_lifetime_start_p0.Invoke(8L, &ptr2);
					ptr2 = (byte*)ptr + num + -1;
					int num2;
					if ((byte)(*(sbyte*)ptr2) == (byte)b)
					{
						result = ptr2;
						num2 = 1;
					}
					else
					{
						num2 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &ptr2);
					switch (num2)
					{
					case 0:
						goto IL_00a1;
					}
				}
				else
				{
					result = null;
				}
				break;
				IL_00a1:
				num += -1L;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
