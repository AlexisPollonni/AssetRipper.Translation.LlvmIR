using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_next_var_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIeEET_v")]
	[DemangledName("long double __llvm_libc_20_1_2_::internal::ArgList::next_var<long double>()")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("this")] Internal_ArgList* This)
	{
		unchecked
		{
			void** overflow_arg_area = &((Va_list_tag*)(&This->Vlist))->Overflow_arg_area;
			void* ptr = Llvm_ptrmask_p0_i64.Invoke((byte*)(*overflow_arg_area) + 15, -16L);
			*overflow_arg_area = (byte*)ptr + 16;
			return *(double*)ptr;
		}
	}
}
