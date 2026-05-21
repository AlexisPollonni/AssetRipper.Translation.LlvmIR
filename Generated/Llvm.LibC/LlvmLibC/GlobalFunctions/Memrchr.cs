using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memrchr
{
	[MangledName("memrchr")]
	[DemangledName("memrchr")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C, [MangledName("n")] long N)
	{
		void* result = null;
		void* ptr = null;
		sbyte b = 0;
		void* ptr2 = null;
		long num = N;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Src;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)C;
			while (true)
			{
				if (num != 0L)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
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
					Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
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
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
