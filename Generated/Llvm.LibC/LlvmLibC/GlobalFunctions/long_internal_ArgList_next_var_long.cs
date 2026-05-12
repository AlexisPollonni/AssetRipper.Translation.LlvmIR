using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIlEET_v")]
[DemangledName("long __llvm_libc_20_1_2_::internal::ArgList::next_var<long>()")]
internal static partial class long_internal_ArgList_next_var_long
{
	public unsafe static long Invoke(internal_ArgList* @this)
	{
		unchecked
		{
			va_list_tag* vlist = (va_list_tag*)(&@this->vlist);
			int* gp_offset = &vlist->gp_offset;
			int num = *gp_offset;
			nint num2;
			if ((uint)num <= 40u)
			{
				num2 = (nint)((byte*)vlist->reg_save_area + num);
				*gp_offset = num + 8;
			}
			else
			{
				void** overflow_arg_area = &vlist->overflow_arg_area;
				void* ptr = *overflow_arg_area;
				*overflow_arg_area = (byte*)ptr + 8;
				num2 = (nint)ptr;
			}
			return *(long*)num2;
		}
	}
}
