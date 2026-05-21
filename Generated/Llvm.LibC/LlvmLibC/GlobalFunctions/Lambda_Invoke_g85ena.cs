using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_g85ena
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil12raise_exceptEiENKUltE_clEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)::'lambda'(unsigned short)::operator()(unsigned short) const")]
	[CleanName("Lambda_Invoke")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("singleExceptFlag")][NativeType("unsigned short")] short SingleExceptFlag)
	{
		Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor llvm_libc_20_1_2_fputil_internal_X87StateDescriptor = default(Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		int num = 0;
		short num2 = SingleExceptFlag;
		Llvm_lifetime_start_p0.Invoke(28L, &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor) = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[1] = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[2] = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[3] = -21846;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor) + 8;
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)ptr)[2] = -1431655766;
			((int*)ptr)[3] = -1431655766;
			((int*)ptr)[4] = -1431655766;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			Internal_get_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			num = Internal_get_mxcsr.Invoke();
			int num3 = (ushort)num2;
			short* ptr2 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Status_word;
			*ptr2 = (short)((ushort)(*ptr2) | num3);
			num |= (ushort)num2;
			Internal_write_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			Internal_write_mxcsr.Invoke(num);
			Internal_fwait.Invoke();
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(28L, &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		}
	}
}
