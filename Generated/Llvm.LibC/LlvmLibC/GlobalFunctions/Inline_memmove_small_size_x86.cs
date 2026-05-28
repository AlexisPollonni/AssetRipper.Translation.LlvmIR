using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memmove_small_size_x86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_29inline_memmove_small_size_x86EPNS_3cpp4byteEPKS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_small_size_x86(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static bool Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		long num2 = Count;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
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
				Memmove_unsigned_char_block.Invoke(Dst, Src);
				result = true;
				break;
			case 2L:
				Memmove_unsigned_short_block.Invoke(Dst, Src);
				result = true;
				break;
			case 3L:
				Memmove_cpp_array_unsigned_char_3ul_block.Invoke(Dst, Src);
				result = true;
				break;
			case 4L:
				Memmove_unsigned_int_block.Invoke(Dst, Src);
				result = true;
				break;
			case 5L:
			case 6L:
			case 7L:
				Memmove_unsigned_int_head_tail.Invoke(Dst, Src, num2);
				result = true;
				break;
			default:
				{
					if (true)
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
						Memmove_cpp_array_unsigned_char_vector_16_4ul_head_tail.Invoke(Dst, Src, num2);
						result = true;
					}
					else
					{
						result = false;
					}
					break;
				}
				IL_0176:
				Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail.Invoke(Dst, Src, num2);
				result = true;
				break;
				IL_0105:
				Memmove_unsigned_long_head_tail.Invoke(Dst, Src, num2);
				result = true;
				break;
				IL_013f:
				Memmove_unsigned_char_vector_16_head_tail.Invoke(Dst, Src, num2);
				result = true;
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
