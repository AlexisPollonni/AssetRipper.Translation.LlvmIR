using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_next_var_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIDRlEET_v")]
	[DemangledName("long _Fract __llvm_libc_20_1_2_::internal::ArgList::next_var<long _Fract>()")]
	[return: NativeType("long")]
	public unsafe static int Invoke([MangledName("this")] Internal_ArgList* This)
	{
		unchecked
		{
			void** overflow_arg_area = &((Va_list_tag*)(&This->Vlist))->Overflow_arg_area;
			void* ptr = *overflow_arg_area;
			*overflow_arg_area = (byte*)ptr + 8;
			return *(int*)ptr;
		}
	}
}
