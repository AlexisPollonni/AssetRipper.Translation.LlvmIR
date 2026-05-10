using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE11parse_flagsEPm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_flags(unsigned long*)")]
internal static partial class printf_core_Parser_internal_ArgList_parse_flags_unsigned_long
{
	public unsafe static sbyte Invoke(void* @this, void* local_pos)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 1;
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		unchecked
		{
			while ((b & 1) == 1)
			{
				switch (((sbyte*)((printf_core_Parser*)@this)->str)[*(long*)local_pos])
				{
				case 45:
					b2 = (sbyte)((byte)b2 | 1);
					break;
				case 43:
					b2 = (sbyte)((byte)b2 | 2);
					break;
				case 32:
					b2 = (sbyte)((byte)b2 | 4);
					break;
				case 35:
					b2 = (sbyte)((byte)b2 | 8);
					break;
				case 48:
					b2 = (sbyte)((byte)b2 | 0x10);
					break;
				default:
					b = 0;
					break;
				}
				if ((b & 1) == 1)
				{
					(*(long*)local_pos)++;
				}
			}
			sbyte result = b2;
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
