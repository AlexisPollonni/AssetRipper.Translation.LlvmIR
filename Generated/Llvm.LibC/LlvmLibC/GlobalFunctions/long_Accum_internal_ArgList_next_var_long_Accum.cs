using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIDAlEET_v")]
[DemangledName("long _Accum __llvm_libc_20_1_2_::internal::ArgList::next_var<long _Accum>()")]
internal static partial class long_Accum_internal_ArgList_next_var_long_Accum
{
	public unsafe static long Invoke(internal_ArgList* @this)
	{
		unchecked
		{
			void** overflow_arg_area = &((va_list_tag*)(&@this->vlist))->overflow_arg_area;
			void* ptr = *overflow_arg_area;
			*overflow_arg_area = (byte*)ptr + 8;
			return *(long*)ptr;
		}
	}
}
