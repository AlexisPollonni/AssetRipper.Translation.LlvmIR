using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_set_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10set_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_except(int)")]
	public unsafe static int Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		short num = 0;
		Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor llvm_libc_20_1_2_fputil_internal_X87StateDescriptor = default(Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = Internal_get_status_value_for_except.Invoke(Excepts);
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
			Internal_get_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			int num3 = (ushort)num;
			short* ptr2 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Status_word;
			*ptr2 = (short)((ushort)(*ptr2) | num3);
			Internal_write_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Internal_get_mxcsr.Invoke();
			num2 |= (ushort)num;
			Internal_write_mxcsr.Invoke(num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(28L, &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return 0;
		}
	}
}
