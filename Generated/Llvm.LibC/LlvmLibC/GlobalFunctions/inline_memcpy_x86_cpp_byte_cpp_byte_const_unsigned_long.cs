using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_17inline_memcpy_x86EPNS_3cpp4byteEPKS1_m")]
[DemangledName("__llvm_libc_20_1_2_::inline_memcpy_x86(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class inline_memcpy_x86_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		long num2 = count;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		unchecked
		{
			switch (num2)
			{
			case 1L:
				builtin_Memcpy_1ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				break;
			case 2L:
				builtin_Memcpy_2ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				break;
			case 3L:
				builtin_Memcpy_3ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				break;
			case 4L:
				builtin_Memcpy_4ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				break;
			case 5L:
			case 6L:
			case 7L:
				builtin_Memcpy_4ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				break;
			default:
				if (uint.MaxValue != 0)
				{
					if ((ulong)num2 < 16uL)
					{
						goto IL_00ed;
					}
				}
				else if ((ulong)num2 <= 16uL)
				{
					goto IL_00ed;
				}
				if (false)
				{
					if ((ulong)num2 < 32uL)
					{
						goto IL_011f;
					}
				}
				else if ((ulong)num2 <= 32uL)
				{
					goto IL_011f;
				}
				if (false)
				{
					if ((ulong)num2 < 64uL)
					{
						goto IL_0151;
					}
				}
				else if ((ulong)num2 <= 64uL)
				{
					goto IL_0151;
				}
				inline_memcpy_x86_sse2_ge64_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				break;
			case 0L:
				break;
				IL_0151:
				builtin_Memcpy_32ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				break;
				IL_011f:
				builtin_Memcpy_16ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				break;
				IL_00ed:
				builtin_Memcpy_8ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
