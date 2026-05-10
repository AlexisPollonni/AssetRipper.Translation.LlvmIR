using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIDRiEET_v")]
[DemangledName("_Fract __llvm_libc_20_1_2_::internal::ArgList::next_var<_Fract>()")]
internal static partial class Fract_internal_ArgList_next_var_Fract
{
	public unsafe static short Invoke(void* @this)
	{
		unchecked
		{
			void** overflow_arg_area = &((va_list_tag*)(&((internal_ArgList*)@this)->vlist))->overflow_arg_area;
			void* ptr = *overflow_arg_area;
			*overflow_arg_area = (byte*)ptr + 8;
			return *(short*)ptr;
		}
	}
}
