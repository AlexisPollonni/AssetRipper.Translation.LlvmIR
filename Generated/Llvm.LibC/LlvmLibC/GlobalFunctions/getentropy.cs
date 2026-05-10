using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getentropy
{
	public unsafe static int Invoke(void* buffer, long length)
	{
		int result = 0;
		void* ptr = null;
		long num = 0L;
		int num2 = 0;
		long num3 = length;
		if (unchecked((ulong)num3) > 256uL)
		{
			Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 5);
			result = -1;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = buffer;
			int num4;
			do
			{
				if (num3 != 0L)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num);
					num = long_syscall_impl_long_char_unsigned_long_int_long_char_unsigned_long_int.Invoke(318L, ptr, num3, 0);
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
						llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = -unchecked((int)num);
						if (num2 == 4)
						{
							num4 = 2;
						}
						else
						{
							Errno_operator_int_dntwiy.Invoke(a: InstructionHelper.Select(num2 == 38, 38, 5), @this: libc_errno.Pointer);
							result = -1;
							num4 = 1;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num2);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num);
					continue;
				}
				result = 0;
				break;
			}
			while (num4 == 2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
		}
		return result;
	}
}
