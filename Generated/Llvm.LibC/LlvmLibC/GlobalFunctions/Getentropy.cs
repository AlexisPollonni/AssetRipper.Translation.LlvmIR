using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getentropy
{
	[MangledName("getentropy")]
	[DemangledName("getentropy")]
	public unsafe static int Invoke([MangledName("buffer")] void* Buffer, [MangledName("length")] long Length)
	{
		int result = 0;
		void* ptr = null;
		long num = 0L;
		int num2 = 0;
		long num3 = Length;
		if (unchecked((ulong)num3) > 256uL)
		{
			Errno_Assignment.Invoke(Libc_errno.Pointer, 5);
			result = -1;
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Buffer;
			int num4;
			do
			{
				if (num3 != 0L)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num);
					num = Syscall_impl_long_char_unsigned_long_int.Invoke(318L, ptr, num3, 0);
					if (num >= 0L)
					{
						unchecked
						{
							num3 -= num;
							ptr = (byte*)ptr + num;
							num4 = 2;
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = -unchecked((int)num);
						if (num2 == 4)
						{
							num4 = 2;
						}
						else
						{
							Errno_Assignment.Invoke(A: InstructionHelper.Select(num2 == 38, 38, 5), This: Libc_errno.Pointer);
							result = -1;
							num4 = 1;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num2);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num);
					continue;
				}
				result = 0;
				break;
			}
			while (num4 == 2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		}
		return result;
	}
}
