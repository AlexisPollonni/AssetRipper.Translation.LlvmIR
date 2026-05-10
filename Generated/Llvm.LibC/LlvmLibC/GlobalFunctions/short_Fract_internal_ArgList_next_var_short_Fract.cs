using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIDRsEET_v")]
[DemangledName("short _Fract __llvm_libc_20_1_2_::internal::ArgList::next_var<short _Fract>()")]
internal static partial class short_Fract_internal_ArgList_next_var_short_Fract
{
	public unsafe static sbyte Invoke(void* @this)
	{
		unchecked
		{
			void** overflow_arg_area = &((va_list_tag*)(&((internal_ArgList*)@this)->vlist))->overflow_arg_area;
			void* ptr = *overflow_arg_area;
			*overflow_arg_area = (byte*)ptr + 8;
			return *(sbyte*)ptr;
		}
	}
}
