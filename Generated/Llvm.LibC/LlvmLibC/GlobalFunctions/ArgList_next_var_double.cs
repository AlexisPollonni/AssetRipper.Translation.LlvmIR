using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_next_var_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIdEET_v")]
	[DemangledName("double __llvm_libc_20_1_2_::internal::ArgList::next_var<double>()")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("this")] Internal_ArgList* This)
	{
		unchecked
		{
			Va_list_tag* vlist = (Va_list_tag*)(&This->Vlist);
			int* fp_offset = &vlist->Fp_offset;
			int num = *fp_offset;
			nint num2;
			if ((uint)num <= 160u)
			{
				num2 = (nint)((byte*)vlist->Reg_save_area + num);
				*fp_offset = num + 16;
			}
			else
			{
				void** overflow_arg_area = &vlist->Overflow_arg_area;
				void* ptr = *overflow_arg_area;
				*overflow_arg_area = (byte*)ptr + 8;
				num2 = (nint)ptr;
			}
			return *(double*)num2;
		}
	}
}
