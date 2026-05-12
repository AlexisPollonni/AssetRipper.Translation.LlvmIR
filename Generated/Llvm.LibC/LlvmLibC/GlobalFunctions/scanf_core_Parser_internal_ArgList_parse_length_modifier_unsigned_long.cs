using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
internal static partial class scanf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long
{
	public unsafe static LengthModifier_3739tr Invoke(scanf_core_Parser* @this, void* local_pos)
	{
		unchecked
		{
			switch (((sbyte*)@this->str)[*(long*)local_pos])
			{
			case 108:
				if (((sbyte*)@this->str)[*(long*)local_pos + 1L] == 108)
				{
					*(long*)local_pos += 2L;
					return LengthModifier_3739tr.ll;
				}
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.l;
			case 104:
				if (((sbyte*)@this->str)[*(long*)local_pos + 1L] == 104)
				{
					*(long*)local_pos += 2L;
					return LengthModifier_3739tr.hh;
				}
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.h;
			case 76:
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.L;
			case 106:
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.j;
			case 122:
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.z;
			case 116:
				(*(long*)local_pos)++;
				return LengthModifier_3739tr.t;
			default:
				return LengthModifier_3739tr.NONE;
			}
		}
	}
}
