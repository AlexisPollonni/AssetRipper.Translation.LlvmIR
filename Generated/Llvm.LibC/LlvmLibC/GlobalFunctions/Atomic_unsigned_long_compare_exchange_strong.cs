using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_long_compare_exchange_strong
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE23compare_exchange_strongERmmNS0_11MemoryOrderES4_NS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::compare_exchange_strong(unsigned long&, unsigned long, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public unsafe static bool Invoke([MangledName("this")] Fputil_internal_FPStorage_v3nexn* This, [MangledName("expected")][NativeType("unsigned long&")] void* Expected, [MangledName("desired")][NativeType("unsigned long")] long Desired, [MangledName("success_order")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder Success_order, [MangledName("failure_order")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder Failure_order, [MangledName("mem_scope")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope Mem_scope)
	{
		long num = Desired;
		void* location = Atomic_unsigned_long_addressof.Invoke(&This->Val);
		int num2 = Atomic_unsigned_long_order.Invoke(Success_order);
		void* ptr = Atomic_unsigned_long_addressof.Invoke(Expected);
		void* ptr2 = Atomic_unsigned_long_addressof.Invoke(&num);
		int num3 = Atomic_unsigned_long_order.Invoke(Failure_order);
		unchecked
		{
			sbyte b;
			switch (num2)
			{
			default:
			{
				int num6 = num3;
				if (num6 != 1 && num6 != 2)
				{
					if (num6 != 5)
					{
						Unsafe.SkipInit(out bool field_26);
						long field_25 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_26);
						Struct_u6p3uf struct_u6p3uf19 = new Struct_u6p3uf
						{
							field_0 = field_25,
							field_1 = field_26
						};
						Struct_u6p3uf struct_u6p3uf20 = struct_u6p3uf19;
						long field_27 = struct_u6p3uf20.field_0;
						Struct_u6p3uf struct_u6p3uf21 = struct_u6p3uf19;
						bool field_28 = struct_u6p3uf21.field_1;
						if (!field_28)
						{
							*(long*)ptr = field_27;
						}
						b = (field_28 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_30);
						long field_29 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_30);
						Struct_u6p3uf struct_u6p3uf22 = new Struct_u6p3uf
						{
							field_0 = field_29,
							field_1 = field_30
						};
						Struct_u6p3uf struct_u6p3uf23 = struct_u6p3uf22;
						long field_31 = struct_u6p3uf23.field_0;
						Struct_u6p3uf struct_u6p3uf24 = struct_u6p3uf22;
						bool field_32 = struct_u6p3uf24.field_1;
						if (!field_32)
						{
							*(long*)ptr = field_31;
						}
						b = (field_32 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_34);
					long field_33 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_34);
					Struct_u6p3uf struct_u6p3uf25 = new Struct_u6p3uf
					{
						field_0 = field_33,
						field_1 = field_34
					};
					Struct_u6p3uf struct_u6p3uf26 = struct_u6p3uf25;
					long field_35 = struct_u6p3uf26.field_0;
					Struct_u6p3uf struct_u6p3uf27 = struct_u6p3uf25;
					bool field_36 = struct_u6p3uf27.field_1;
					if (!field_36)
					{
						*(long*)ptr = field_35;
					}
					b = (field_36 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 1:
			case 2:
			{
				int num8 = num3;
				if (num8 != 1 && num8 != 2)
				{
					if (num8 != 5)
					{
						Unsafe.SkipInit(out bool field_50);
						long field_49 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_50);
						Struct_u6p3uf struct_u6p3uf37 = new Struct_u6p3uf
						{
							field_0 = field_49,
							field_1 = field_50
						};
						Struct_u6p3uf struct_u6p3uf38 = struct_u6p3uf37;
						long field_51 = struct_u6p3uf38.field_0;
						Struct_u6p3uf struct_u6p3uf39 = struct_u6p3uf37;
						bool field_52 = struct_u6p3uf39.field_1;
						if (!field_52)
						{
							*(long*)ptr = field_51;
						}
						b = (field_52 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_54);
						long field_53 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_54);
						Struct_u6p3uf struct_u6p3uf40 = new Struct_u6p3uf
						{
							field_0 = field_53,
							field_1 = field_54
						};
						Struct_u6p3uf struct_u6p3uf41 = struct_u6p3uf40;
						long field_55 = struct_u6p3uf41.field_0;
						Struct_u6p3uf struct_u6p3uf42 = struct_u6p3uf40;
						bool field_56 = struct_u6p3uf42.field_1;
						if (!field_56)
						{
							*(long*)ptr = field_55;
						}
						b = (field_56 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_58);
					long field_57 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_58);
					Struct_u6p3uf struct_u6p3uf43 = new Struct_u6p3uf
					{
						field_0 = field_57,
						field_1 = field_58
					};
					Struct_u6p3uf struct_u6p3uf44 = struct_u6p3uf43;
					long field_59 = struct_u6p3uf44.field_0;
					Struct_u6p3uf struct_u6p3uf45 = struct_u6p3uf43;
					bool field_60 = struct_u6p3uf45.field_1;
					if (!field_60)
					{
						*(long*)ptr = field_59;
					}
					b = (field_60 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 3:
			{
				int num5 = num3;
				if (num5 != 1 && num5 != 2)
				{
					if (num5 != 5)
					{
						Unsafe.SkipInit(out bool field_14);
						long field_13 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_14);
						Struct_u6p3uf struct_u6p3uf10 = new Struct_u6p3uf
						{
							field_0 = field_13,
							field_1 = field_14
						};
						Struct_u6p3uf struct_u6p3uf11 = struct_u6p3uf10;
						long field_15 = struct_u6p3uf11.field_0;
						Struct_u6p3uf struct_u6p3uf12 = struct_u6p3uf10;
						bool field_16 = struct_u6p3uf12.field_1;
						if (!field_16)
						{
							*(long*)ptr = field_15;
						}
						b = (field_16 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_18);
						long field_17 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_18);
						Struct_u6p3uf struct_u6p3uf13 = new Struct_u6p3uf
						{
							field_0 = field_17,
							field_1 = field_18
						};
						Struct_u6p3uf struct_u6p3uf14 = struct_u6p3uf13;
						long field_19 = struct_u6p3uf14.field_0;
						Struct_u6p3uf struct_u6p3uf15 = struct_u6p3uf13;
						bool field_20 = struct_u6p3uf15.field_1;
						if (!field_20)
						{
							*(long*)ptr = field_19;
						}
						b = (field_20 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_22);
					long field_21 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_22);
					Struct_u6p3uf struct_u6p3uf16 = new Struct_u6p3uf
					{
						field_0 = field_21,
						field_1 = field_22
					};
					Struct_u6p3uf struct_u6p3uf17 = struct_u6p3uf16;
					long field_23 = struct_u6p3uf17.field_0;
					Struct_u6p3uf struct_u6p3uf18 = struct_u6p3uf16;
					bool field_24 = struct_u6p3uf18.field_1;
					if (!field_24)
					{
						*(long*)ptr = field_23;
					}
					b = (field_24 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 4:
			{
				int num7 = num3;
				if (num7 != 1 && num7 != 2)
				{
					if (num7 != 5)
					{
						Unsafe.SkipInit(out bool field_38);
						long field_37 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_38);
						Struct_u6p3uf struct_u6p3uf28 = new Struct_u6p3uf
						{
							field_0 = field_37,
							field_1 = field_38
						};
						Struct_u6p3uf struct_u6p3uf29 = struct_u6p3uf28;
						long field_39 = struct_u6p3uf29.field_0;
						Struct_u6p3uf struct_u6p3uf30 = struct_u6p3uf28;
						bool field_40 = struct_u6p3uf30.field_1;
						if (!field_40)
						{
							*(long*)ptr = field_39;
						}
						b = (field_40 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_42);
						long field_41 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_42);
						Struct_u6p3uf struct_u6p3uf31 = new Struct_u6p3uf
						{
							field_0 = field_41,
							field_1 = field_42
						};
						Struct_u6p3uf struct_u6p3uf32 = struct_u6p3uf31;
						long field_43 = struct_u6p3uf32.field_0;
						Struct_u6p3uf struct_u6p3uf33 = struct_u6p3uf31;
						bool field_44 = struct_u6p3uf33.field_1;
						if (!field_44)
						{
							*(long*)ptr = field_43;
						}
						b = (field_44 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_46);
					long field_45 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_46);
					Struct_u6p3uf struct_u6p3uf34 = new Struct_u6p3uf
					{
						field_0 = field_45,
						field_1 = field_46
					};
					Struct_u6p3uf struct_u6p3uf35 = struct_u6p3uf34;
					long field_47 = struct_u6p3uf35.field_0;
					Struct_u6p3uf struct_u6p3uf36 = struct_u6p3uf34;
					bool field_48 = struct_u6p3uf36.field_1;
					if (!field_48)
					{
						*(long*)ptr = field_47;
					}
					b = (field_48 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 5:
			{
				int num4 = num3;
				if (num4 != 1 && num4 != 2)
				{
					if (num4 != 5)
					{
						Unsafe.SkipInit(out bool field_2);
						long field_ = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_2);
						Struct_u6p3uf struct_u6p3uf = new Struct_u6p3uf
						{
							field_0 = field_,
							field_1 = field_2
						};
						Struct_u6p3uf struct_u6p3uf2 = struct_u6p3uf;
						long field_3 = struct_u6p3uf2.field_0;
						Struct_u6p3uf struct_u6p3uf3 = struct_u6p3uf;
						bool field_4 = struct_u6p3uf3.field_1;
						if (!field_4)
						{
							*(long*)ptr = field_3;
						}
						b = (field_4 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						Unsafe.SkipInit(out bool field_6);
						long field_5 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_6);
						Struct_u6p3uf struct_u6p3uf4 = new Struct_u6p3uf
						{
							field_0 = field_5,
							field_1 = field_6
						};
						Struct_u6p3uf struct_u6p3uf5 = struct_u6p3uf4;
						long field_7 = struct_u6p3uf5.field_0;
						Struct_u6p3uf struct_u6p3uf6 = struct_u6p3uf4;
						bool field_8 = struct_u6p3uf6.field_1;
						if (!field_8)
						{
							*(long*)ptr = field_7;
						}
						b = (field_8 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					Unsafe.SkipInit(out bool field_10);
					long field_9 = InstructionHelper.AtomicCompareExchangeInt64(comparand: *(long*)ptr, location: location, value: *(long*)ptr2, exchanged: &field_10);
					Struct_u6p3uf struct_u6p3uf7 = new Struct_u6p3uf
					{
						field_0 = field_9,
						field_1 = field_10
					};
					Struct_u6p3uf struct_u6p3uf8 = struct_u6p3uf7;
					long field_11 = struct_u6p3uf8.field_0;
					Struct_u6p3uf struct_u6p3uf9 = struct_u6p3uf7;
					bool field_12 = struct_u6p3uf9.field_1;
					if (!field_12)
					{
						*(long*)ptr = field_11;
					}
					b = (field_12 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			}
			return (b & 1) == 1;
		}
	}
}
