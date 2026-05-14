using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIeEET_v")]
[DemangledName("long double __llvm_libc_20_1_2_::internal::ArgList::next_var<long double>()")]
internal static partial class long_double_internal_ArgList_next_var_long_double
{
	public unsafe static double Invoke(internal_ArgList* @this)
	{
		unchecked
		{
			void** overflow_arg_area = &((va_list_tag*)(&@this->vlist))->overflow_arg_area;
			void* ptr = llvm_ptrmask_p0_i64.Invoke((byte*)(*overflow_arg_area) + 15, -16L);
			*overflow_arg_area = (byte*)ptr + 16;
			return *(double*)ptr;
		}
	}
}
