using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_29inline_memmove_small_size_x86EPNS_3cpp4byteEPKS1_m")]
[DemangledName("__llvm_libc_20_1_2_::inline_memmove_small_size_x86(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class inline_memmove_small_size_x86_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static bool Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		long num2 = count;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		unchecked
		{
			bool result;
			switch (num2)
			{
			case 0L:
				result = true;
				break;
			case 1L:
				generic_Memmove_unsigned_char_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				result = true;
				break;
			case 2L:
				generic_Memmove_unsigned_short_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				result = true;
				break;
			case 3L:
				generic_Memmove_cpp_array_unsigned_char_3ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				result = true;
				break;
			case 4L:
				generic_Memmove_unsigned_int_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
				result = true;
				break;
			case 5L:
			case 6L:
			case 7L:
				generic_Memmove_unsigned_int_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				result = true;
				break;
			default:
				{
					if (uint.MaxValue != 0)
					{
						if ((ulong)num2 < 16uL)
						{
							goto IL_0105;
						}
					}
					else if ((ulong)num2 <= 16uL)
					{
						goto IL_0105;
					}
					if (false)
					{
						if ((ulong)num2 < 32uL)
						{
							goto IL_013f;
						}
					}
					else if ((ulong)num2 <= 32uL)
					{
						goto IL_013f;
					}
					if (false)
					{
						if ((ulong)num2 < 64uL)
						{
							goto IL_0176;
						}
					}
					else if ((ulong)num2 <= 64uL)
					{
						goto IL_0176;
					}
					if ((ulong)num2 <= 128uL)
					{
						generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
						result = true;
					}
					else
					{
						result = false;
					}
					break;
				}
				IL_0176:
				generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				result = true;
				break;
				IL_0105:
				generic_Memmove_unsigned_long_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				result = true;
				break;
				IL_013f:
				generic_Memmove_unsigned_char_vector_16_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num2);
				result = true;
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
