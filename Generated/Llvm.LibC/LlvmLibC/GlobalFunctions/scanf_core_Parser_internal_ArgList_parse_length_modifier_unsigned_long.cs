using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
internal static partial class scanf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long
{
	public unsafe static int Invoke(void* @this, void* local_pos)
	{
		unchecked
		{
			switch (((sbyte*)((scanf_core_Parser*)@this)->str)[*(long*)local_pos])
			{
			case 108:
				if (((sbyte*)((scanf_core_Parser*)@this)->str)[*(long*)local_pos + 1L] == 108)
				{
					*(long*)local_pos += 2L;
					return 3;
				}
				(*(long*)local_pos)++;
				return 2;
			case 104:
				if (((sbyte*)((scanf_core_Parser*)@this)->str)[*(long*)local_pos + 1L] == 104)
				{
					*(long*)local_pos += 2L;
					return 0;
				}
				(*(long*)local_pos)++;
				return 1;
			case 76:
				(*(long*)local_pos)++;
				return 7;
			case 106:
				(*(long*)local_pos)++;
				return 4;
			case 122:
				(*(long*)local_pos)++;
				return 5;
			case 116:
				(*(long*)local_pos)++;
				return 6;
			default:
				return 8;
			}
		}
	}
}
